using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Winium;
using System;
using System.Configuration;

namespace Winium.Core.Framework.Driver
{
    public class NativeDriver
    {
        static IWebDriver _driver;

        private static readonly Lazy<NativeDriver> _instance = new Lazy<NativeDriver>(() =>
        {
            _driver = InititeWiniumDriver();
            return new NativeDriver();
        });

        public static NativeDriver Instance
        {
            get { return _instance.Value; }
        }

        public IWebDriver NativeWiniumDriver
        {
            get { return _driver; }
        }

        private static IWebDriver InititeWiniumDriver()
        {
            try
            {
                var options = new DesktopOptions();
                options.ApplicationPath = ConfigurationManager.AppSettings["Applicationpath"];

                var capabilities = (DesiredCapabilities)options.ToCapabilities();
                var driver = new RemoteWebDriver(new Uri("http://localhost:9999"), capabilities);
                return driver;
                
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Dispose()
        {
            try
            {
                _driver.Close();
            }

            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
