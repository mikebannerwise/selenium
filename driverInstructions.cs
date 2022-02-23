using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace selenium
{
    class driverInstructions
    {
        public void clickElementWhenClickable(WebDriver driver, IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30)); 
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
    }
}