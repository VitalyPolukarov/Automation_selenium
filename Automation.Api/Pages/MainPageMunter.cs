using Automation.Api.Components;
using Automation.Core.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Automation.Api.Pages
{
    public interface MainPageMunter : Ifluent, IPageNavigator<MainPageMunter>, IMenu

    {
        MainPageMunter FindByXpath(string xpath,string str);
        MainPageMunter SubmitByXpath(string xpath);
    }
}
