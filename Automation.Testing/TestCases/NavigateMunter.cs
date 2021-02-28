using Automation.Api.Components;
using Automation.Core.Components;
using Automation.Core.Testing;
using Automation.Extantions.Contracts;
using Automation.Framework.UI.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Automation.Testing.TestCases
{
    public class NavigateMunter : TestCase
    {
        public override bool AutomationTest(IDictionary<string, object> testParams)
        {
            var actual = new IFluentUI(Driver)
                .ChangeContext<LogInMunterUI>();

            Thread.Sleep(1000);
            actual.SubmitByXpath("//*[@id='treeview_active']");
            Thread.Sleep(1000);
            actual.SubmitByXpath("//*[@id='treeview_active']/ul/li/div[1]");
            Thread.Sleep(1000);
            return true;
        }
    }

}
