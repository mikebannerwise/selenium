using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace selenium
{
    class addElements
    {
        driverInstructions instructions = new driverInstructions();
        
        public void addLogo(WebDriver driver)
        {
            IWebElement addElement=instructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[1]/div[3]/div/div[1]/i",10);
            instructions.clickElementWhenClickable(driver, addElement);

            IWebElement logo=instructions.getElementAfterWaitXP(driver,"/html/body/div[7]/div/div/div[1]/div",10);
            instructions.clickElementWhenClickable(driver, logo);

            IWebElement dropArea=instructions.getElementAfterWaitID(driver,"ngf-upload-logo-browse-files-link",10);
            dropArea.SendKeys("/Users/mikemccormick/Documents/Resources/images/bannerwise-blue.svg");

            IWebElement image=instructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[2]/div/div/div[2]/div[1]/div[1]/div/div[1]/div/div[1]",10);
            instructions.clickElementWhenClickable(driver, image);

            IWebElement add=instructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[2]/div/div/div[3]/button[2]",10);
            instructions.clickElementWhenClickable(driver, add);

            Thread.Sleep(2000);
            Actions actions = new Actions(driver);
            actions.SendKeys(Keys.Escape)
            .Perform();
        }

        public void addImage(WebDriver driver)
        {
            IWebElement addElement=instructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[1]/div[3]/div/div[1]/i",10);
            instructions.clickElementWhenClickable(driver, addElement);

            IWebElement image=instructions.getElementAfterWaitXP(driver,"/html/body/div[6]/div/div/div[2]/div/h5",10);
            instructions.clickElementWhenClickable(driver, image);

            IWebElement dropArea=instructions.getElementAfterWaitID(driver,"ngf-upload-image-browse-files-link",10);
            dropArea.SendKeys("/Users/mikemccormick/Documents/Resources/images/flower.jpeg");
                    
            IWebElement image2=instructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[2]/div/div/div[2]/div[1]/div[1]/div/div[1]/div/div[1]",10);
            instructions.clickElementWhenClickable(driver, image2);

            IWebElement add=instructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[2]/div/div/div[3]/button[2]",10);
            instructions.clickElementWhenClickable(driver, add);
            
            Thread.Sleep(2000);
            Actions actions = new Actions(driver);
            actions.SendKeys(Keys.Escape)
            .Perform();
        }

        public void addText(WebDriver driver)
        {
            IWebElement addElement=instructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[1]/div[3]/div/div[1]/i",10);
            instructions.clickElementWhenClickable(driver, addElement);

            IWebElement textElement=instructions.getElementAfterWaitXP(driver,"/html/body/div[6]/div/div/div[3]/div/h5",10);
            instructions.clickElementWhenClickable(driver, textElement);

            IWebElement chooseGoogleFont=instructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[2]/div/div/div[2]/div[2]/button[2]",10);
            Thread.Sleep(500);
            instructions.clickElementWhenClickable(driver, chooseGoogleFont);

            IWebElement ABeeZee=instructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[2]/div/div/div[2]/div[1]/div[1]/div/div[1]/div[1]/div[1]/h4",10);
            instructions.clickElementWhenClickable(driver, ABeeZee);

            IWebElement addFont=instructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[2]/div/div/div[3]/button[2]",10);
            instructions.clickElementWhenClickable(driver, addFont);
            
            Thread.Sleep(2000);
            Actions actions = new Actions(driver);
            actions.SendKeys(Keys.Escape)
            .Perform();
        }

        public void addButton(WebDriver driver)
        {
            IWebElement addElement=instructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[1]/div[3]/div/div[1]/i",10);
            instructions.clickElementWhenClickable(driver, addElement);

            IWebElement buttonElement=instructions.getElementAfterWaitXP(driver,"/html/body/div[6]/div/div/div[4]/div/h5",10);
            instructions.clickElementWhenClickable(driver, buttonElement);

            IWebElement button=instructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[2]/div/div/div[2]/div[1]/div[1]/div[2]/div/h5",10);
            instructions.clickElementWhenClickable(driver, button);

            IWebElement add=instructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[2]/div/div/div[3]/button[2]",10);
            instructions.clickElementWhenClickable(driver, add);

            Thread.Sleep(2000);
            Actions actions = new Actions(driver);
            actions.SendKeys(Keys.Escape)
            .Perform();
        }

        public void addShape(WebDriver driver)
        {
            IWebElement addElement=instructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[1]/div[3]/div/div[1]/i",10);
            instructions.clickElementWhenClickable(driver, addElement);

            IWebElement shapeElement=instructions.getElementAfterWaitXP(driver,"/html/body/div[6]/div/div/div[5]/div/h5",10);
            instructions.clickElementWhenClickable(driver, shapeElement);

            IWebElement publicShape=instructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[2]/div/div/div[2]/div[2]/button[2]",10);
            instructions.clickElementWhenClickable(driver, publicShape);
            
            Thread.Sleep(2000);
            IWebElement rectangle=instructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[2]/div/div/div[2]/div[1]/div[1]/div/div[1]/div[3]/div[2]/div/h5",10);
            instructions.clickElementWhenClickable(driver, rectangle);

            IWebElement add=instructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[2]/div/div/div[3]/button[2]",10);
            instructions.clickElementWhenClickable(driver, add);
        }

        public void addVideo(WebDriver driver)
        {
            IWebElement addElement=instructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[1]/div[3]/div/div[1]/i",10);
            instructions.clickElementWhenClickable(driver, addElement);

            IWebElement videoElement=instructions.getElementAfterWaitXP(driver,"/html/body/div[6]/div/div/div[6]/div/h5",10);
            instructions.clickElementWhenClickable(driver, videoElement);

            IWebElement dropArea=instructions.getElementAfterWaitID(driver,"ngf-upload-video-browse-files-link",10);
            dropArea.SendKeys("/Users/mikemccormick/Documents/Resources/videos/small.mp4");

            IWebElement video=instructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[2]/div/div/div[2]/div[1]/div[1]/div/div[1]/div/div[2]/div/h5",10);
            instructions.clickElementWhenClickable(driver, video);

            IWebElement add=instructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[2]/div/div/div[3]/button[2]",10);
            instructions.clickElementWhenClickable(driver, add);
        }

        public void addDisclaimer(WebDriver driver)
        {
            IWebElement addElement=instructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[1]/div[3]/div/div[1]/i",10);
            instructions.clickElementWhenClickable(driver, addElement);

            IWebElement disclaimerElement=instructions.getElementAfterWaitXP(driver,"/html/body/div[6]/div/div/div[7]/div/h5",10);
            instructions.clickElementWhenClickable(driver, disclaimerElement);
        }
    }
} 