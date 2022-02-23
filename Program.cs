using OpenQA.Selenium;

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
            driverInstructions dInstructions = new driverInstructions();
            browserInstructions bInstructions = new browserInstructions();
            addElements add = new addElements();
            if (browser == "firefox" || browser == "ff")
            {
                driver = dInstructions.setUpFirefox();
            }
            else if (browser == "safari")
            {
                driver = dInstructions.setUpSafari();
            }
            else
            {
                driver = dInstructions.setUpChrome();
            }

            bInstructions.goToCanvas(driver, environment, flow, network, size);
            add.addLogo(driver);
            add.addImage(driver);
            add.addText(driver);
            bInstructions.editSelectedTextElement(driver);
            driver.Quit();
        }
    }
}