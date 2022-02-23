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
            string networkXPath=getXpath(network);
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

        public string getXpath(string network)
        {
            string xPath="";
            switch (network)
            
            {
                case "googleads":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[1]/h5";
                break;
                case "360":
                xPath="/html/body/div[7]/div/div[2]/div[1]/div/div[2]/h5";
                break;
                case "gcm":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[3]/h5";
                break;
                case "googlestudio":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[4]/h5";
                break;
                case "adform":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[5]/h5";
                break;
                case "aol":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[6]/h5";
                break;
                case "adlib":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[7]/h5";
                break;
                case "adroll":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[8]/h5";
                break;
                case "adcombi":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[9]/h5";
                break;
                case "adcrowd":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[10]/h5";
                break;
                case "adformmraid":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[11]/h5";
                break;
                case "adition":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[12]/h5";
                break;
                case "adscience":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[13]/h5";
                break;
                case "adtech":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[14]/h5";
                break;
                case "atlasfacebook":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[15]/h5";
                break;
                case "bvdw":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[16]/h5";
                break;
                case "beeinteractive":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[17]/h5";
                break;
                case "bidtheatre":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[18]/h5";
                break;
                case "campusmedia":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[19]/h5";
                break;
                case "daisycon":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[20]/h5";
                break;
                case "delta":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[21]/h5";
                break;
                case "exterion":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[22]/h5";
                break;
                case "flashtalking":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[23]/h5";
                break;
                case "fusion":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[24]/h5";
                break;
                case "googleadmanager":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[25]/h5";
                break;
                case "horizont":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[26]/h5";
                break;
                case "iab":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[27]/h5";
                break;
                case "iabaustria":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[28]/h5";
                break;
                case "iabmraid":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[29]/h5";
                break;
                case "mediaimpact":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[30]/h5";
                break;
                case "mediamath":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[31]/h5";
                break;
                case "openx":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[32]/h5";
                break;
                case "161":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[33]/h5";
                break;
                case "quantcast":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[34]/h5";
                break;
                case "rtl":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[35]/h5";
                break;
                case "revive":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[36]/h5";
                break;
                case "rocketfuel":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[37]/h5";
                break;
                case "sizmek":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[38]/h5";
                break;
                case "smartadserver":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[39]/h5";
                break;
                case "smartadtags":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[40]/h5";
                break;
                case "targetoo":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[41]/h5";
                break;
                case "tradedesk":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[42]/h5";
                break;
                case "tradedoubler":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[43]/h5";
                break;
                case "tradetracker":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[44]/h5";
                break;
                case "turn":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[45]/h5";
                break;
                case "verivox":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[46]/h5";
                break;
                case "weborama":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[47]/h5";
                break;
                case "xandr":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[48]/h5";
                break;
                case "yahoo":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[49]/h5";
                break;
                case "html":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[50]/h5";
                break;
                case "match2one":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[51]/h5";
                break;
                case "yielder":
                xPath="/html/body/div[6]/div/div[2]/div[1]/div/div[52]/h5";
                break;
                default:
                break;
            }
            return xPath;
        }
    }
}

