using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _157SuggestionsForCSharp
{
    interface ISuggestionTest
    {
        void Test();
    }
    interface IClone
    {
        object ShallowClone();
        object DeepClone();
    }
}
