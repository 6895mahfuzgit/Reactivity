using Reactivity.Domain.Interfaces;
using Reactivity.Domain.Models;
using Reactivity.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Reactivity.Infra.Data.Repository
{
    public class ValueRepository : IValueRepository
    {
        private readonly ReactivlyDBContext _context;

        public ValueRepository(ReactivlyDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Value> GetValues()
        {
            try
            {
                return _context.Values;
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
                return _context.Values.FirstOrDefault(x => x.Id == id);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
