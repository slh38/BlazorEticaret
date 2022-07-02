using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Common
{
   public  interface IResults
    {
        bool IsSucces { get; set; }
        string Message { get; set; }
    }
}
