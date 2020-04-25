using MediatR;
using Reactivity.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Reactivity.Infra.Data.Command.Activities
{
    public class Delete
    {
        public class Command : IRequest
        {
            public Guid Id { get; set; }
        }



        public class Handler : IRequestHandler<Command>
        {
            private readonly ReactivlyDBContext _context;

            public Handler(ReactivlyDBContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {

                var activity = await _context.Activities.FindAsync(request.Id);

                if (activity == null)
                {
                    throw new Exception("Can't find any activity!");
                }

                _context.Remove(activity);
                var success = await _context.SaveChangesAsync() > 0;
                if (success) return Unit.Value;

                throw new Exception("Failed to delete activity???");
            }
        }
    }
}
