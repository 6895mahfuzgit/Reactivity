using MediatR;
using Reactivity.Domain.Models;
using Reactivity.Infra.Data.Context;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Reactivity.Infra.Data.Command.Activities
{
    public class Create
    {

        public class Command : IRequest
        {
            public Guid Id { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public string Category { get; set; }
            public DateTime Date { get; set; }
            public string City { get; set; }
            public string Venue { get; set; }
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
                var activity = new Activity
                {
                    Id = request.Id,
                    Title = request.Title,
                    Description = request.Description,
                    Category = request.Category,
                    Date = request.Date,
                    City = request.City,
                    Venue = request.Venue
                };

                _context.Add(activity);
                var success = await _context.SaveChangesAsync() > 0;
                if (success) return Unit.Value;

                throw new Exception("Failed to save activity???");
            }
        }
    }




}
