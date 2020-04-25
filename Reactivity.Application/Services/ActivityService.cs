using MediatR;
using Reactivity.Application.Interfaces;
using Reactivity.Domain.Models;
using Reactivity.Infra.Data.Command.Activities;
using Reactivity.Infra.Data.Query.Activies;
using Reactivity.Infra.Data.Query.Activities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Reactivity.Application.Services
{
    public class ActivityService : IActivityService
    {
        private readonly IMediator _mediator;

        public ActivityService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IEnumerable<Activity>> GetAllActivities()
        {
            return await _mediator.Send(new List.Query());
        }

        public async Task<Activity> GetActivityById(Guid id)
        {
            return await _mediator.Send(new Details.Query { Id = id });
        }

        public async Task<Unit> SaveActivity(Activity activity)
        {
            Create.Command command = new Create.Command();
            command.Id = activity.Id;
            command.Title = activity.Title;
            command.Description = activity.Description;
            command.Date = activity.Date;
            command.Category = activity.Category;
            command.Venue = activity.Venue;
            command.City = activity.City;

            return await _mediator.Send(command);
        }

        public async Task<Unit> UpdateActivity(Activity activity)
        {
            Edit.Command command = new Edit.Command();
            command.Id = activity.Id;
            command.Title = activity.Title;
            command.Description = activity.Description;
            command.Date = activity.Date;
            command.Category = activity.Category;
            command.Venue = activity.Venue;
            command.City = activity.City;

            return await _mediator.Send(command);
        }

        public async Task<Unit> Delete(Guid id)
        {
            return await _mediator.Send(new Delete.Command { Id = id });
        }
    }
}
