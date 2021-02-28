using System;
using System.Collections.Generic;
using System.Text;

namespace Automation.Core.Components
{
    public interface IMenu
    {
        T Menu<T>(string menuName);
    }
}
