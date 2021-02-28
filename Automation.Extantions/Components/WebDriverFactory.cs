using Automation.Extantions.Contracts;
using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Automation.Extantions.Components
{
    public class WebDriverFactory
    {
        private readonly DriverParams driverParams;
        public WebDriverFactory(string driverParams) : this(LoadParams(driverParams)) { }

        public WebDriverFactory(DriverParams driverParams)
        {
            this.driverParams = driverParams;

            if(string.IsNullOrEmpty(driverParams.Binaries) || driverParams.Binaries == ".")
            {
                driverParams.Binaries = Environment.CurrentDirectory;
            }
        }
       
        public IWebDriver Get()
        {
            return GetChrome();
        }
        /// <summary>
        /// Private functions area 
        /// </summary>
 
        //local web driver
        private IWebDriver GetChrome() => new ChromeDriver(driverParams.Binaries);

        private static DriverParams LoadParams(string driverParams)
        {
            if(string.IsNullOrEmpty(driverParams))
            {
                return new DriverParams { Source = "Local", Driver = "Chrome", Binaries = "." };
            }
            return JsonConvert.DeserializeObject<DriverParams>(driverParams);
        }
    }
}
