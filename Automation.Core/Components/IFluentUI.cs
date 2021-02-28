using Automation.Core.Logging;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Automation.Core.Components
{
    public class IFluentUI : Ifluent
    { 
        public IWebDriver Driver { get; }

        public ILogger Logger { get; }
        public IFluentUI(IWebDriver driver, ILogger logger)
            {
                Driver = driver;
                Logger = logger;
            }

        public IFluentUI(IWebDriver driver)
            : this(driver, new TraceLogger()) { }

        public T ChangeContext<T>()           
        {
            var instance = Create<T>(null);
            Logger.Debug($"instance of [{GetType()?.FullName}] created");
            return instance;
        }

        public T ChangeContext<T>(ILogger logger)
        {
            var instance = Create<T>(logger);
            logger.Debug($"instance of [{GetType()?.FullName}] created");
            return instance;
        }

        public T ChangeContext<T>(string application)
        {
            Driver.Navigate().GoToUrl(application);
            Driver.Manage().Window.Maximize();
            var instance = Create<T>(null);
            Logger.Debug($"instance of [{GetType()?.FullName}] created");
            return instance;
        }

        public T ChangeContext<T>(string application, ILogger logger)
        {
            Driver.Navigate().GoToUrl(application);
            Driver.Manage().Window.Maximize();

            var instance = Create<T>(logger);
            logger.Debug($"instance of [{GetType()?.FullName}] created");
            return instance;
        }

        private T Create<T>(ILogger logger)
        {
            return logger == null ?
                (T)Activator.CreateInstance(typeof(T), new object[] { Driver })
                : (T)Activator.CreateInstance(typeof(T), new object[] { Driver, logger });
        }
    }
}
