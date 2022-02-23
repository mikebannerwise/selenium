using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Safari;

namespace selenium
{
    class browserOptions
    {
        public FirefoxOptions firefox()
        {
            var options = new FirefoxOptions();
            return options;
        }

        public ChromeOptions chrome()
        {
            var options = new ChromeOptions();
            options.AddArguments("--disable-popup-blocking");
            return options;
        }

        public SafariOptions safari()
        {
            var options = new SafariOptions();
            return options;
        }
    }
}