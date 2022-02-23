using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Safari;

namespace selenium
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            string browser = "chrome";
            string network = "googleads";
            string flow = "displayStandard";
            string fbAdSize="singleImage";
            string environment="client";

            p.printSettings(environment, browser,network,flow);
            Console.WriteLine("To update settings, type 'browser=safari', 'network=adlogica', etc");
            Console.WriteLine("To run tests, type 'run'");
            string input = Console.ReadLine();

            if (input.StartsWith("environment"))
            {
                if (input.EndsWith("client"))
                {
                    environment="client";
                    p.printSettings(environment, browser,network,flow);
                }
                else if(input.EndsWith("staging"))
                {
                    environment="staging";
                    p.printSettings(environment, browser,network,flow);
                }
                else if(input.EndsWith("testing"))
                {
                    environment="testing";
                    p.printSettings(environment, browser,network,flow);
                }
                else
                {
                    Console.WriteLine("unknown environment");
                    p.printSettings(environment, browser,network,flow);
                }
            }
            else if (input.StartsWith("browser"))
            {
                if (input.EndsWith("chrome"))
                {
                    browser="chrome";
                    p.printSettings(environment, browser,network,flow);
                }
                else if(input.EndsWith("ff") || input.EndsWith("fox"))
                {
                    browser="firefox";
                    p.printSettings(environment, browser,network,flow);
                }
                else if(input.EndsWith("safari"))
                {
                    browser="safari";
                    p.printSettings(environment, browser,network,flow);
                }
                else
                {
                    Console.WriteLine("unknown browser");
                    p.printSettings(environment, browser,network,flow);
                }
            }
            else if (input.StartsWith("network"))
            {
                if (input.EndsWith("adlogica"))
                {
                    network="adlogica";
                    p.printSettings(environment, browser,network,flow);
                }
                else if (input.EndsWith("googleads"))
                {
                    network="googleads";
                    p.printSettings(environment, browser,network,flow);
                }
                else
                {
                    Console.WriteLine("unknown network");
                    p.printSettings(environment, browser,network,flow);
                }
            }
            else if (input.StartsWith("flow"))
            {
                //
            }
            else if(input=="run")
            {
                WebDriver driver;
                browserInstructions instructions = new browserInstructions();
                addElements add = new addElements();
                if(browser=="firefox")
                {
                    driver = p.setUpFirefox();
                }
                else if(browser=="safari")
                    {
                    driver = p.setUpSafari();
                    }
                else
                {
                    driver = p.setUpChrome();
                }

                Console.WriteLine("goToCanvas"+" "+driver+" "+network+" "+flow+" "+fbAdSize);
                instructions.goToCanvas(driver, environment, flow, network, fbAdSize);
                Console.WriteLine("addLogo");
                add.addLogo(driver);
                Console.WriteLine("addImage");
                add.addImage(driver);
                Console.WriteLine("addText");
                add.addText(driver);
                instructions.editSelectedTextElement(driver);

                // instructions.clickPreview(driver);
                // instructions.downloadZipFromPreview(driver);
            }
            else
            {
                Console.WriteLine("bad command");
            }
        }

        public void printSettings(string environment, string browser, string network, string flow)
        {
            Console.WriteLine("Current settings:\nenvironment:"+environment+"   browser:"+browser+"   network:"+network+"   flow:"+flow+"\n");
        }

        public ChromeDriver setUpChrome()
        {
            browserOptions options = new browserOptions();
            var ChromeOptions=options.chrome();
            var driver = new ChromeDriver(ChromeOptions);
            return driver;
        }

        public FirefoxDriver setUpFirefox()
        {
            browserOptions options = new browserOptions();
            var FirefoxOptions=options.firefox();
            var driver = new FirefoxDriver(FirefoxOptions);
            return driver;
        }

        public SafariDriver setUpSafari()
        {
            browserOptions options = new browserOptions();
            var SafariOptions=options.safari();
            var driver = new SafariDriver(SafariOptions);
            return driver;
        }
    }
}