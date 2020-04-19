using Reactivity.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reactivity.Application.ViewModels
{
    public class ValueViewModel
    {
        public IEnumerable<Value> Values { get; set; }
    }
}
