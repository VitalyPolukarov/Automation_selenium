using Automation.Core.Components;
using Automation.Core.Testing;
using Automation.Framework.UI.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Automation.Testing.TestCases
{
    public class RoomeManagerMunter : TestCase
    {
        public override bool AutomationTest(IDictionary<string, object> testParams)
        {
            var user = $"{testParams["User"]}";
            var password = $"{testParams["Password"]}";
            var rnd = new Random();
            var actual = new IFluentUI(Driver)
                .ChangeContext<LogInMunterUI>();
           
            //menu
            Thread.Sleep(1000);
            actual.SubmitByXpath("/html/body/app-root/app-host-mode-shell/div/div/div[1]/app-header/div/div/div[1]/button");
            Thread.Sleep(1000);
            //climate
            actual.SubmitByXpath("//*[@id='Climate']");
            Thread.Sleep(1000);
            //temperature
            actual.SubmitByXpath("/html/body/app-root/app-host-mode-shell/div/div/div[2]/div/app-sidebar/div/p-sidebar/div/div/div[2]/div[1]");
            Thread.Sleep(1000);
            //edit
            actual.SubmitByXpath("/html/body/app-root/app-host-mode-shell/div/div/div[2]/div/ng-component/form/div[1]/app-telemetry-header/app-toolbar/div/div[2]/div");
            Thread.Sleep(1000);
            //Target
            actual.FindByXpath("//*[@id='k - cf038aa8 - cc22 - 6381 - 7dab - ea6c02a8abbb]", Convert.ToString(rnd.Next(1, 100)));
            Thread.Sleep(1000);
            //Low T
            actual.FindByXpath("//*[@id='k - 49eb31ce - 39ca - 9587 - 1aea - c62b6353ed67']", Convert.ToString(rnd.Next(1, 100)));
            Thread.Sleep(1000);
            //High T
            actual.FindByXpath("//*[@id='k - 8a67531f - fb74 - d07b - 13dc - c9837ff0a7d6']", Convert.ToString(rnd.Next(1, 100)));
            Thread.Sleep(1000);
            //Save
            actual.SubmitByXpath("/html/body/app-root/app-host-mode-shell/div/div/div[2]/div/ng-component/form/div[1]/app-telemetry-header/app-toolbar/div/div[2]/div[2]/div");
            Thread.Sleep(1000);
           
            return true;
        }
    }
}
