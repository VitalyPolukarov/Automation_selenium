using Automation.Api.Components;
using Automation.Core.Components;
using Automation.Core.Testing;
using Automation.Framework.UI.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Automation.Testing.TestCases
{
    public class LogInMunter : TestCase
    {
        public override bool AutomationTest(IDictionary<string, object> testParams)
        {
            var user = $"{testParams["User"]}";
            var password = $"{testParams["Password"]}";

            var actual = new IFluentUI(Driver)
                .ChangeContext<LogInMunterUI>($"{testParams["application"]}");

            Thread.Sleep(5000);
            actual.FindByXpath("//input[@id='signInName']", user);
            actual.FindByXpath("//input[@id='password']", password);
            actual.SubmitByXpath("//*[@id='next']");
            
            return true;
        }
    }
}
