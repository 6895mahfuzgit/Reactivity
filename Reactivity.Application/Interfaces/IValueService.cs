using Reactivity.Application.ViewModels;
using Reactivity.Domain.Models;

namespace Reactivity.Application.Interfaces
{
    public interface IValueService
    {
        ValueViewModel GetValues();
        Value GetValueById(int id);
    }
}
