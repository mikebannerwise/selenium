using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Safari;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace selenium
{
    class driverInstructions
    {
        public ChromeDriver setUpChrome()
        {
            browserOptions options = new browserOptions();
            var ChromeOptions = options.chrome();
            var driver = new ChromeDriver(ChromeOptions);
            return driver;
        }

        public FirefoxDriver setUpFirefox()
        {
            browserOptions options = new browserOptions();
            var FirefoxOptions = options.firefox();
            var driver = new FirefoxDriver(FirefoxOptions);
            return driver;
        }

        public SafariDriver setUpSafari()
        {
            browserOptions options = new browserOptions();
            var SafariOptions = options.safari();
            var driver = new SafariDriver(SafariOptions);
            return driver;
        }
        
        public void clickElementWhenClickable(WebDriver driver, IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5)); 
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
            element.Click();
        }

        public IWebElement getElementAfterWaitXP(WebDriver driver, string xpath, int timeout)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeout);
            IWebElement element = driver.FindElement(By.XPath(xpath));
            return element;
        }

        public IWebElement getElementAfterWaitID(WebDriver driver, string id, int timeout)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeout);
            IWebElement element = driver.FindElement(By.Id(id));
            return element;
        }

        public void pressEsc(WebDriver driver)
        {
            Actions actions = new Actions(driver);
            actions.SendKeys(Keys.Escape)
            .Perform();
        }
    }
}