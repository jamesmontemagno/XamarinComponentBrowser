using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XamarinComponentBrowser.Models
{
    [Flags]
    public enum Platform
    {
        None = 0,
        iOS = 1,
        Android = 2,
        UWP = 4
    }
}
