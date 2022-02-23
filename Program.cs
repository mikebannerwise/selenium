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
            string input = "";
            string environment = "testing";
            string browser = "chrome";
            string network = "googleads";
            string flow = "displayStandard";
            string size = "singleImage";

            while (input != "quit")
            {
                p.userPrompt(environment, browser, network, flow);

                input = Console.ReadLine();
                if (input.StartsWith("environment"))
                {
                    environment = input.Substring(input.IndexOf("=") + 1);
                }
                else if (input.StartsWith("browser"))
                {
                    browser = input.Substring(input.IndexOf("=") + 1);
                }
                else if (input.StartsWith("network"))
                {
                    network = input.Substring(input.IndexOf("=") + 1);
                }
                else if (input.StartsWith("flow"))
                {
                    flow = input.Substring(input.IndexOf("=") + 1);
                }
                else if (input.StartsWith("size"))
                {
                    size = input.Substring(input.IndexOf("=") + 1);
                }
                else if (input == "run")
                {
                    p.run(browser, environment, network, flow, size);
                    break;
                }
                else if (input == "quit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("bad command");
                    }
                }
        }

        public void userPrompt(string environment, string browser, string network, string flow)
        {
            Console.WriteLine("To update settings, type 'browser=safari', 'network=adlogica', etc");
            Console.WriteLine("To run tests, type 'run'");
            Console.WriteLine("\n\nsettings:\nenvironment:" + environment.ToUpper() + "   browser:" + browser.ToUpper() + "   network:" + network.ToUpper() + "   flow:" + flow.ToUpper() + "\n");
        }

        public void run(string browser, string environment, string network, string flow, string size)
        {
            WebDriver driver;
            browserInstructions instructions = new browserInstructions();
            addElements add = new addElements();
            if (browser == "firefox")
            {
                driver = this.setUpFirefox();
            }
            else if (browser == "safari")
            {
                driver = this.setUpSafari();
            }
            else
            {
                driver = this.setUpChrome();
            }

            instructions.goToCanvas(driver, environment, flow, network, size);
            add.addLogo(driver);
            add.addImage(driver);
            add.addText(driver);
            instructions.editSelectedTextElement(driver);
            driver.Quit();
        }

        public string getEnvironment()
        {
            string environment;
            if (Console.ReadLine().EndsWith("client"))
            {
                environment = "client";
            }
            else if (Console.ReadLine().EndsWith("staging"))
            {
                environment = "staging";
            }
            else if (Console.ReadLine().EndsWith("testing"))
            {
                environment = "testing";
            }
            else
            {
                environment = "???";
                Console.WriteLine("unknown environment");
            }
            return environment;
        }

        public string getBrowser(string input)
        {
            string browser;
            if (input.EndsWith("chrome"))
            {
                browser = "chrome";
            }
            else if (input.EndsWith("firefox") || input.EndsWith("ff"))
            {
                browser = "firefox";
            }
            else if (input.EndsWith("safari"))
            {
                browser = "safari";
            }
            else
            {
                browser = "???";
                Console.WriteLine("unknown browser");
            }
            return browser;
        }
        public string getNetwork()
        {
            string input = Console.ReadLine();
            return input;
        }
        public string getFlow()
        {
            string flow;
            if (Console.ReadLine().EndsWith("socialDynamic"))
            {
                flow = "socialDynamic";
            }
            else if (Console.ReadLine().EndsWith("displayStandard"))
            {
                flow = "displayStandard";
            }
            else if (Console.ReadLine().EndsWith("displayDynamic"))
            {
                flow = "displayDynamic";
            }
            else
            {
                flow = "???";
                Console.WriteLine("unknown flow");
            }
            return flow;
        }
        public string getSize()
        {
            string size;
            if (Console.ReadLine().EndsWith("singleImage"))
            {
                size = "singleImage";
            }
            else if (Console.ReadLine().EndsWith("carousel"))
            {
                size = "carousel";
            }
            else if (Console.ReadLine().EndsWith("displayDynamic"))
            {
                size = "collection";
            }
            else
            {
                size = "???";
                Console.WriteLine("unknown flow");
            }
            return size;
        }

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
    }
}