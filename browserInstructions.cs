using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace selenium
{
    class browserInstructions
    {
        driverInstructions instructions = new driverInstructions();
        public void login(WebDriver driver, string environment)
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://"+environment+".bannerwise.io");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement UserName = driver.FindElement(By.Name("email"));
            IWebElement Password = driver.FindElement(By.Name("password"));
            IWebElement submitLogin = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div/div[2]/div[2]/form/button"));
            UserName.SendKeys("mike@bannerwise.io");
            Password.SendKeys("!Sabydny8");
            submitLogin.Click();
        }

        public void displayStandardFlow(WebDriver driver, string network, string networkXPath)
        {
            IWebElement displayAds=instructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[1]/div[2]/div[2]/div[1]/div/div/div[2]/div[1]/div[2]/button",15);
            instructions.clickElementWhenClickable(driver, displayAds);

            IWebElement displayStandard=instructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[2]/div/div/div[2]/div/div[1]/div[2]/button",10);
            instructions.clickElementWhenClickable(driver, displayStandard);

            IWebElement dropdown=instructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[2]/div/div/div[2]/div/div/div",10);
            instructions.clickElementWhenClickable(driver, dropdown);

            IWebElement chosenNetwork=instructions.getElementAfterWaitXP(driver,networkXPath,10);
            instructions.clickElementWhenClickable(driver, chosenNetwork);

            IWebElement continu=instructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[2]/div/div/div[3]/button[2]",10);
            instructions.clickElementWhenClickable(driver, continu);

            IWebElement fromScratch=instructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[2]/div/div/div[2]/div/div[1]/div[2]/button",10);
            instructions.clickElementWhenClickable(driver, fromScratch);

            IWebElement sizeBox=instructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[2]/div/div/div[2]/div[1]/div[1]/div/div/div[1]",10);
            instructions.clickElementWhenClickable(driver, sizeBox);
            
            continu=instructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[2]/div/div/div[3]/button[2]",10);
            instructions.clickElementWhenClickable(driver, continu);

            IWebElement nameAd=instructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[2]/div/div/div[2]/form/div[1]/div/input",10);
            nameAd.SendKeys("selenium test - " + network);

            continu=instructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[2]/div/div/div[3]/button",10);
            instructions.clickElementWhenClickable(driver, continu);
        }
        public void displayDynamicFlow(WebDriver driver, string network)
        {
            Console.Write("network: " + network);
            IWebElement displayAds=instructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[1]/div[2]/div[2]/div[1]/div/div/div[2]/div[1]/div[2]/button",15);
            instructions.clickElementWhenClickable(driver, displayAds);

            IWebElement displayDynamic=instructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[2]/div/div/div[2]/div/div[2]/div[2]/button",10);
            instructions.clickElementWhenClickable(driver, displayDynamic);

            IWebElement feedSearch=instructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[2]/div/div[1]/div[2]/div[2]/div/input",10);
            instructions.clickElementWhenClickable(driver, feedSearch);
            feedSearch.SendKeys(network+"-selenium");

            IWebElement chooseFeed=instructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[2]/div/div[1]/div[2]/div[1]/div[2]/div/div[1]/div/div/div/div[4]/a",10);
            instructions.clickElementWhenClickable(driver, chooseFeed);

            IWebElement fromScratch=instructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[2]/div/div/div[2]/div/div[1]/div[2]/button",10);
            instructions.clickElementWhenClickable(driver, fromScratch);

            IWebElement sizeBox=instructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[2]/div/div/div[2]/div[1]/div[1]/div/div/div[1]",10);
            instructions.clickElementWhenClickable(driver, sizeBox);
            
            IWebElement continu=instructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[2]/div/div/div[3]/button[2]",10);
            instructions.clickElementWhenClickable(driver, continu);

            IWebElement nameAd=instructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[2]/div/div/div[2]/form/div[1]/div/input",10);
            nameAd.SendKeys("selenium test - " + network);

            continu=instructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[2]/div/div/div[3]/button",10);
            instructions.clickElementWhenClickable(driver, continu);
        }

        public void socialDynamicFlow(WebDriver driver, string network, string size)
        {
            IWebElement socialAds=instructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[1]/div[2]/div[2]/div[1]/div/div/div[2]/div[2]/div[2]/button",15);
            instructions.clickElementWhenClickable(driver, socialAds);

            IWebElement socialDynamic=instructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[2]/div/div/div[2]/div/div[3]/div[2]/button",10);
            instructions.clickElementWhenClickable(driver, socialDynamic);

            IWebElement feedSearch=instructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[2]/div/div[1]/div[2]/div[2]/div/input",10);
            instructions.clickElementWhenClickable(driver, feedSearch);
            feedSearch.SendKeys("facebook-selenium");

            IWebElement chooseFeed=instructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[2]/div/div[1]/div[2]/div[1]/div[2]/div/div[1]/div/div/div/div[4]/a",10);
            instructions.clickElementWhenClickable(driver, chooseFeed);

            IWebElement fromScratch=instructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[2]/div/div/div[2]/div/div[1]/div[2]/button",10);
            instructions.clickElementWhenClickable(driver, fromScratch);

            if(size=="carousel")
            {
                IWebElement carousel=instructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[2]/div/div/div[2]/div/div[1]/div[2]/button",10);
                instructions.clickElementWhenClickable(driver, carousel);
            }
            else if(size=="singleImage" || size is null)
            {
                IWebElement singleImage=instructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[2]/div/div/div[2]/div/div[2]/div[2]/button",10);
                instructions.clickElementWhenClickable(driver, singleImage);
            }
            else if(size=="collection")
            {
                IWebElement carousel=instructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[2]/div/div/div[2]/div/div[3]/div[2]/button",10);
                instructions.clickElementWhenClickable(driver, carousel);

            }
            else
            {
                Console.WriteLine("bad size in socialDynamic create flow");
            }

            IWebElement nameAd=instructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[2]/div/div/div[2]/form/div[1]/div/input",10);
            nameAd.SendKeys("selenium test - " + network);

            IWebElement continu=instructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[2]/div/div/div[3]/button",10);
            instructions.clickElementWhenClickable(driver, continu);
        }

        public void sizeUpSelectedElement(WebDriver driver)
        {
            IWebElement arrange=instructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[1]/div[3]/div/div[4]/div[3]/div[1]/div[3]",10);
            instructions.clickElementWhenClickable(driver, arrange);

            IWebElement sizeUp=instructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[1]/div[3]/div/div[4]/div[3]/div[2]/div[1]/div/div[3]/div[4]/div[1]/div[2]/div/div/div[1]/i",10);
            for (int i=0; i<8; i++ )
            {
                instructions.clickElementWhenClickable(driver, sizeUp);
            }
        }
        public void editSelectedTextElement(WebDriver driver)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement editText=instructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[1]/div[3]/div/div[3]/div/div[1]/div/div/div[2]/div[1]/div",10);
            editText.Click();

            Actions actions = new Actions(driver);
            actions.DoubleClick(editText).Perform();

            Actions actions2 = new Actions(driver);
            actions2.KeyDown(Keys.Command)
            .SendKeys("A")
            .KeyUp(Keys.Command)
            .SendKeys("Static text element")
            .SendKeys(Keys.Enter)
            .SendKeys("omg wtffffffffffff")
            .SendKeys(Keys.Tab)
            .Perform();

            IWebElement canvas=instructions.getElementAfterWaitID(driver,"canvas",10);
            instructions.clickElementWhenClickable(driver, canvas);
            Thread.Sleep(2000);
        }
        public void clickPreview(WebDriver driver)
        { 
            IWebElement preview=instructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[1]/div[1]/div[2]/div[1]/a/span",10);
            instructions.clickElementWhenClickable(driver, preview);
        }
        public void downloadZipFromPreview(WebDriver driver)
        { 
            IWebElement publish=instructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[1]/div/div[1]/div[2]/div[2]/a",10);
            instructions.clickElementWhenClickable(driver, publish);


            IWebElement continu=instructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[2]/div/div/div[3]/button[2]",10);
            instructions.clickElementWhenClickable(driver, continu);

            IWebElement download=instructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[2]/div/div/div[2]/div/div[2]/div[2]/button",10);
            instructions.clickElementWhenClickable(driver, download);

            IWebElement download2=instructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[2]/div/div/div[3]/button[2]",10);
            instructions.clickElementWhenClickable(driver, download2);
        }

        public void goToCanvas(WebDriver driver, string environment, string flow, string network, string size)
        { 
            hardXPaths xPaths = new hardXPaths();
            string networkXPath=xPaths.getXPaths(network);
            login(driver, environment);
            if(flow=="displayStandard")
            {
                displayStandardFlow(driver, network, networkXPath);
            }
            else if(flow=="displayDynamic")
            {
                displayDynamicFlow(driver, network);
            }
            else if(flow=="socialDynamic")
            {
                socialDynamicFlow(driver, network, size);
            }
        }
    }
}