using MediatR;
using Reactivity.Domain.Models;
using Reactivity.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Reactivity.Infra.Data.Query.Activities
{
    public class Details
    {
        public class Query : IRequest<Activity>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Activity>
        {
            private readonly ReactivlyDBContext _context;

            public Handler(ReactivlyDBContext context)
            {
                _context = context;
            }


            public async Task<Activity> Handle(Query request, CancellationToken cancellationToken)
            {
                var activity = await _context.Activities.FindAsync(request.Id);
                return activity;
            }
        }

    }
}
