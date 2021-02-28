using Automation.Api.Components;
using Automation.Api.Pages;
using Automation.Core.Components;
using Automation.Core.Logging;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Automation.Framework.UI.Pages
{
    public class RoomeManagerMunter : IFluentUI, MainPageMunter
    {
        public RoomeManagerMunter(IWebDriver driver)
            : base(driver) { }

        public RoomeManagerMunter(IWebDriver driver, ILogger logger)
            : base(driver, logger) { }
        MainPageMunter MainPageMunter.FindByXpath(string xpath, string str)
        {
            throw new NotImplementedException();
        }

        T IMenu.Menu<T>(string menuName)
        {
            throw new NotImplementedException();
        }

        MainPageMunter IPageNavigator<MainPageMunter>.Next()
        {
            throw new NotImplementedException();
        }

        int IPageNavigator<MainPageMunter>.Page()
        {
            throw new NotImplementedException();
        }

        int IPageNavigator<MainPageMunter>.Pages()
        {
            throw new NotImplementedException();
        }

        MainPageMunter IPageNavigator<MainPageMunter>.Previous()
        {
            throw new NotImplementedException();
        }

        MainPageMunter MainPageMunter.SubmitByXpath(string xpath)
        {
            throw new NotImplementedException();
        }
    }
}
