using Automation.Api.Components;
using Automation.Core.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Automation.Api.Pages
{
    public interface LogInMunter : Ifluent, IPageNavigator<LogInMunter>, IMenu

    {
        LogInMunter FindByXpath(string xpath,string str);
        LogInMunter SubmitByXpath(string xpath);
    }
}
