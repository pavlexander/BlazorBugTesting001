using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorBugTesting001.Shared.Interfaces
{
    public interface ISelectOption
    {
        public string OptionKey { get; }
        public string OptionValue { get; }
    }
}
