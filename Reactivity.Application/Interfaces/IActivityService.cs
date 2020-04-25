using MediatR;
using Reactivity.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Reactivity.Application.Interfaces
{
    public interface IActivityService
    {
        Task<IEnumerable<Activity>> GetAllActivities();
        Task<Activity> GetActivityById(Guid id);
        Task<Unit> SaveActivity(Activity activity);
        Task<Unit> UpdateActivity(Activity activity);
        Task<Unit> Delete(Guid id);
    }
}
