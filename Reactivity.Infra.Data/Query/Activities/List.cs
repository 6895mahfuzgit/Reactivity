using MediatR;
using Microsoft.EntityFrameworkCore;
using Reactivity.Domain.Models;
using Reactivity.Infra.Data.Context;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Reactivity.Infra.Data.Query.Activies
{
    public class List
    {
        public class Query : IRequest<List<Activity>> { }

        public class Handler : IRequestHandler<Query, List<Activity>>
        {
            private readonly ReactivlyDBContext _context;

            public Handler(ReactivlyDBContext context)
            {
                _context = context;
            }

            public async Task<List<Activity>> Handle(Query request, CancellationToken cancellationToken)
            {
                var activities = await _context.Activities.ToListAsync();
                return activities;
            }
        }
    }
}
