using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Automation.Extantions.Components
{
    public static class WebDriverExtansions
    {
        public static IWebDriver GoToURL(this IWebDriver driver , string url)
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();

            return driver;
        }

        public static IWebElement GetWebElement(this IWebDriver driver , By by , TimeSpan timeSpan )
        {
            var wait = new WebDriverWait(driver, timeSpan);

            return wait.Until(dr => dr.FindElement(by));
        }

        public static SelectElement AsSelect(this IWebElement element) => new SelectElement(element);

        public static IWebElement GetVisibleWebElemet(this IWebDriver driver, By by, TimeSpan timeSpan)
        {
            var wait = new WebDriverWait(driver, timeSpan);

            return wait.Until(dr => 
            {
                var element = dr.FindElement(by);
                return element.Displayed ? element : null;
            });
        }

        public static IWebElement GetEnabledWebElemet(this IWebDriver driver, By by, TimeSpan timeSpan)
        {
            var wait = new WebDriverWait(driver, timeSpan);

            return wait.Until(dr =>
            {
                var element = dr.FindElement(by);
                return element.Enabled ? element : null;
            });
        }

        public static Actions Action(this IWebElement element)
        {
            var driver = ((IWrapsDriver)element).WrappedDriver;
            var action = new Actions(driver);

            return action.MoveToElement(element);
        }

        public static IWebDriver SubmitForm(this IWebDriver driver, int index)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript($"document.form[{index}].submit");

            return driver;
        }

        public static IWebDriver SubmitForm(this IWebDriver driver, string id)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript($"document.form[\"{id}\"].submit");

            return driver;
        }
    }
}
