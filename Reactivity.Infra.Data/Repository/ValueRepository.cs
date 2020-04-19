using Reactivity.Domain.Interfaces;
using Reactivity.Domain.Models;
using Reactivity.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
