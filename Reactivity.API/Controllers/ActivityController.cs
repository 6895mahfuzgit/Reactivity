using MediatR;
using Microsoft.AspNetCore.Mvc;
using Reactivity.Application.Interfaces;
using Reactivity.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Reactivity.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        private readonly IActivityService _activityService;

        public ActivityController(IActivityService activityService)
        {
            _activityService = activityService;
        }

        [HttpGet]
        public async Task<ActionResult<Task<IEnumerable<Activity>>>> GetAllActivities()
        {
            return Ok(await _activityService.GetAllActivities());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Task<IEnumerable<Activity>>>> GetActivitieById(Guid id)
        {
            return Ok(await _activityService.GetActivityById(id));
        }


        [HttpPost]
        public async Task<ActionResult<Unit>> SaveActivity(Activity activity)
        {
            return Ok(await _activityService.SaveActivity(activity));
        }


        [HttpPut]
        public async Task<ActionResult<Unit>> UpdateActivity(Activity activity)
        {
            return Ok(await _activityService.UpdateActivity(activity));
        }

        [HttpDelete("{id}")]
        public async  Task<ActionResult<Unit>> Delete(Guid id)
        {
            return Ok(await _activityService.Delete(id));
        }

    }
}