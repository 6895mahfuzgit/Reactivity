using Reactivity.Domain.Models;
using System.Collections.Generic;

namespace Reactivity.Domain.Interfaces
{
    public interface IValueRepository
    {
        IEnumerable<Value> GetValues();
    }
}
