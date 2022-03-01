using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace selenium
{
    class addElements
    {
        driverInstructions dInstructions = new driverInstructions();
        
        public void addLogo(WebDriver driver)
        {
            IWebElement addElement=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[1]/div[3]/div/div[1]/i",10);
            dInstructions.clickElementWhenClickable(driver, addElement);

            IWebElement logo=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[7]/div/div/div[1]/div",10);
            dInstructions.clickElementWhenClickable(driver, logo);

            IWebElement dropArea=dInstructions.getElementAfterWaitID(driver,"ngf-upload-logo-browse-files-link",10);
            dropArea.SendKeys("/Users/mikemccormick/Documents/Resources/images/bannerwise-blue.svg");

            IWebElement image=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[2]/div/div/div[2]/div[1]/div[1]/div/div[1]/div/div[1]",10);
            dInstructions.clickElementWhenClickable(driver, image);

            IWebElement add=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[2]/div/div/div[3]/button[2]",10);
            dInstructions.clickElementWhenClickable(driver, add);

            Thread.Sleep(2000);
            dInstructions.pressEsc(driver);
        }

        public void addImage(WebDriver driver)
        {
            IWebElement addElement=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[1]/div[3]/div/div[1]/i",10);
            dInstructions.clickElementWhenClickable(driver, addElement);

            IWebElement image=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[6]/div/div/div[2]/div/h5",10);
            dInstructions.clickElementWhenClickable(driver, image);

            IWebElement dropArea=dInstructions.getElementAfterWaitID(driver,"ngf-upload-image-browse-files-link",10);
            dropArea.SendKeys("/Users/mikemccormick/Documents/Resources/images/flower.jpeg");
                    
            IWebElement image2=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[2]/div/div/div[2]/div[1]/div[1]/div/div[1]/div/div[1]",10);
            dInstructions.clickElementWhenClickable(driver, image2);

            IWebElement add=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[2]/div/div/div[3]/button[2]",10);
            dInstructions.clickElementWhenClickable(driver, add);
            
            Thread.Sleep(2000);
            dInstructions.pressEsc(driver);
        }

        public void addText(WebDriver driver)
        {
            IWebElement addElement=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[1]/div[3]/div/div[1]/i",10);
            dInstructions.clickElementWhenClickable(driver, addElement);

            IWebElement textElement=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[6]/div/div/div[3]/div/h5",10);
            dInstructions.clickElementWhenClickable(driver, textElement);

            IWebElement chooseGoogleFont=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[2]/div/div/div[2]/div[2]/button[2]",10);
            Thread.Sleep(500);
            dInstructions.clickElementWhenClickable(driver, chooseGoogleFont);

            IWebElement ABeeZee=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[2]/div/div/div[2]/div[1]/div[1]/div/div[1]/div[1]/div[1]/h4",10);
            dInstructions.clickElementWhenClickable(driver, ABeeZee);

            IWebElement addFont=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[2]/div/div/div[3]/button[2]",10);
            dInstructions.clickElementWhenClickable(driver, addFont);
            
            Thread.Sleep(2000);
            dInstructions.pressEsc(driver);
        }

        public void addButton(WebDriver driver)
        {
            IWebElement addElement=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[1]/div[3]/div/div[1]/i",10);
            dInstructions.clickElementWhenClickable(driver, addElement);

            IWebElement buttonElement=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[6]/div/div/div[4]/div/h5",10);
            dInstructions.clickElementWhenClickable(driver, buttonElement);

            IWebElement button=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[2]/div/div/div[2]/div[1]/div[1]/div[2]/div/h5",10);
            dInstructions.clickElementWhenClickable(driver, button);

            IWebElement add=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[2]/div/div/div[3]/button[2]",10);
            dInstructions.clickElementWhenClickable(driver, add);

            Thread.Sleep(2000);
            dInstructions.pressEsc(driver);
        }

        public void addShape(WebDriver driver)
        {
            IWebElement addElement=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[1]/div[3]/div/div[1]/i",10);
            dInstructions.clickElementWhenClickable(driver, addElement);

            IWebElement shapeElement=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[6]/div/div/div[5]/div/h5",10);
            dInstructions.clickElementWhenClickable(driver, shapeElement);

            IWebElement publicShape=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[2]/div/div/div[2]/div[2]/button[2]",10);
            dInstructions.clickElementWhenClickable(driver, publicShape);
            
            Thread.Sleep(2000);
            IWebElement rectangle=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[2]/div/div/div[2]/div[1]/div[1]/div/div[1]/div[3]/div[2]/div/h5",10);
            dInstructions.clickElementWhenClickable(driver, rectangle);

            IWebElement add=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[2]/div/div/div[3]/button[2]",10);
            dInstructions.clickElementWhenClickable(driver, add);
        }

        public void addVideo(WebDriver driver)
        {
            IWebElement addElement=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[1]/div[3]/div/div[1]/i",10);
            dInstructions.clickElementWhenClickable(driver, addElement);

            IWebElement videoElement=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[6]/div/div/div[6]/div/h5",10);
            dInstructions.clickElementWhenClickable(driver, videoElement);

            IWebElement dropArea=dInstructions.getElementAfterWaitID(driver,"ngf-upload-video-browse-files-link",10);
            dropArea.SendKeys("/Users/mikemccormick/Documents/Resources/videos/small.mp4");

            IWebElement video=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[2]/div/div/div[2]/div[1]/div[1]/div/div[1]/div/div[2]/div/h5",10);
            dInstructions.clickElementWhenClickable(driver, video);

            IWebElement add=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[2]/div/div/div[3]/button[2]",10);
            dInstructions.clickElementWhenClickable(driver, add);
        }

        public void addDisclaimer(WebDriver driver)
        {
            IWebElement addElement=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[1]/div[3]/div/div[1]/i",10);
            dInstructions.clickElementWhenClickable(driver, addElement);

            IWebElement disclaimerElement=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[6]/div/div/div[7]/div/h5",10);
            dInstructions.clickElementWhenClickable(driver, disclaimerElement);
        }
    }
} 