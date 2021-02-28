using Automation.Testing.TestCases;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Assert = NUnit.Framework.Assert;

namespace Automation.Testing.Containers
{
    [TestClass]
    public class MunterTestS
    {
        [DataTestMethod,Order(1)]
        [DataRow("{'driver':'CHROME','User': 'demo@munters.co.il','Password': 'Demo123456','application': 'https://www.trioair.net'}")]
        public void LogIn(string testParams)
        {
            var parameters = JsonConvert.DeserializeObject<Dictionary<string, object>>(testParams);
            var actual = new LogInMunter().WithTestParams(parameters).Execute().Actual;
            Thread.Sleep(5000);
            Assert.IsTrue(actual);
        }

        [DataTestMethod, Order(2)]
        [DataRow("{'driver':'CHROME','User': 'demo@munters.co.il','Password': 'Demo123456','application': 'https://www.trioair.net/#/home'}")]
        public void NavigateUITest(string testParams)
        {
            var parameters = JsonConvert.DeserializeObject<Dictionary<string, object>>(testParams);
            var actual = new NavigateMunter().AutomationTest(parameters);
            Assert.IsTrue(actual);
        }

        [DataTestMethod, Order(3)]
        [DataRow("{'driver':'CHROME','User': 'demo@munters.co.il','Password':'Demo123456','application': 'https://www.trioair.net/#/home'}")]
        public void RoomEditorUITest(string testParams)
        {
            var parameters = JsonConvert.DeserializeObject<Dictionary<string, object>>(testParams);
            var actual = new RoomeManagerMunter().AutomationTest(parameters);
            Assert.IsTrue(actual);
        }
    }
}
