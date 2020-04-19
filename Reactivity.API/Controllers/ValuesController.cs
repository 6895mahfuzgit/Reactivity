using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reactivity.Application.Interfaces;
using Reactivity.Application.ViewModels;
using Reactivity.Domain.Models;

namespace Reactivity.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IValueService _valueService;

        public ValuesController(IValueService valueService)
        {
            _valueService = valueService;
        }

        [HttpGet]
        public ValueViewModel Get()
        {
            try
            {
                return _valueService.GetValues();
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("{id}")]
        public Value Get(int id)
        {
            try
            {
                return _valueService.GetValueById(id);
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}