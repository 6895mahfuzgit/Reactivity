using Reactivity.Application.Interfaces;
using Reactivity.Application.ViewModels;
using Reactivity.Domain.Interfaces;
using Reactivity.Domain.Models;
using System;

namespace Reactivity.Application.Services
{
    public class ValueService : IValueService
    {
        private readonly IValueRepository _valueRepository;

        public ValueService(IValueRepository valueRepository)
        {
            _valueRepository = valueRepository;
        }

        

        public ValueViewModel GetValues()
        {
            try
            {
                var valueListObj = new ValueViewModel
                {
                    Values = _valueRepository.GetValues()
                };

                return valueListObj;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Value GetValueById(int id)
        {
            try
            {
                return _valueRepository.GetValueById(id);

            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
