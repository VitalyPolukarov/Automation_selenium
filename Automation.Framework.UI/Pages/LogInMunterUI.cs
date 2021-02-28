using Automation.Api.Components;
using Automation.Api.Pages;
using Automation.Core.Components;
using Automation.Core.Logging;
using Automation.Extantions.Components;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Automation.Framework.UI.Pages
{
    public class LogInMunterUI : IFluentUI, LogInMunter
    {
        public LogInMunterUI(IWebDriver driver) 
            : base(driver) { }

        public LogInMunterUI(IWebDriver driver, ILogger logger) 
            : base(driver, logger) { }


        public LogInMunter FindByXpath(string xpath,string str)
        {
            Driver
            .GetEnabledWebElemet(By.XPath(xpath), TimeSpan.FromSeconds(1)).SendKeys(str);
            return this;
        }

        public LogInMunter SubmitByXpath(string xpath)
        {
            Driver
            .GetEnabledWebElemet(By.XPath(xpath), TimeSpan.FromSeconds(1)).Click();
            return this;
        }

        public T Menu<T>(string menuName)
        {
            throw new NotImplementedException();
        }

        public LogInMunter Next()
        {
            throw new NotImplementedException();
        }

        public int Page()
        {
            throw new NotImplementedException();
        }

        public int Pages()
        {
            throw new NotImplementedException();
        }

        public LogInMunter Previous()
        {
            throw new NotImplementedException();
        }

    }
}
