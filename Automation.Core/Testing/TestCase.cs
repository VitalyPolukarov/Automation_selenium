using Automation.Core.Logging;
using Automation.Extantions.Components;
using Automation.Extantions.Contracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Automation.Core.Testing
{
    public abstract class TestCase
    {
        //fields
        private int attemps;
        private ILogger logger;
        private IDictionary<string, object> testParams;

        protected TestCase()
        {
            testParams = new Dictionary<string, object>();
            attemps = 1;
            logger = new TraceLogger();
        }
        //components
        public abstract bool AutomationTest(IDictionary<string, object> testParams);

        public TestCase Execute()
        {
            for(int i = 0; i < attemps; i++)
            {
                Driver = Get();
                try
                {
                    Actual = AutomationTest(testParams);
                    if (Actual)
                    {
                        break;
                    }
                    logger.Debug($"[{GetType()?.FullName}] failed on attempt [{i + 1}]");
                }
                catch(AssertInconclusiveException ex)
                {
                    logger.Debug(ex, ex.Message);
                    break;
                }
                catch (NotImplementedException ex)
                {
                    logger.Debug(ex, ex.Message);
                    break;
                }
                catch(Exception ex)
                {
                    logger.Debug(ex , ex.Message);
                }
                finally
                {
                   // Driver?.Close();
                   // Driver?.Dispose();
                }
            }
            return this;
        }

        //properties
        public bool Actual { get; private set; }
        public static IWebDriver Driver { get; set; }
        //configuration
        public TestCase WithTestParams(IDictionary<string, object> testParams)
        {
            this.testParams = testParams;

            return this;
        }

        public TestCase WithNumberOfAttemps(int numberOfAttempts)
        {
            attemps = numberOfAttempts;
            return this;
        }

        public TestCase WithLogger(ILogger logger)
        {
            this.logger = logger;

            return this;
        }

        //setup
        public IWebDriver Get()
        {
            var DRIVER = "driver";

            //default
            var driverParams = new DriverParams { Binaries = ".", Driver = "CHROME" };

            //use existing
            if(testParams?.ContainsKey(DRIVER) == true)
            {
                driverParams.Driver = $"{testParams[DRIVER]}";
            }
            //create driver
            return new WebDriverFactory(driverParams).Get();
        }
    }
}
