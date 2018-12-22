using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XamarinComponentBrowser.Models;

namespace XamarinComponentBrowser.Interfaces
{
    public interface IComponentService
    {
        IEnumerable<XamarinComponent> GetComponents(int skip);
    }
}
