using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace selenium
{
    class addAnimations
    {
        driverInstructions dInstructions = new driverInstructions();
        
        public void loadEnterAnimations(WebDriver driver)
        { 
            IWebElement loadEnterAnimations=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[1]/div[3]/div/div[5]/div[1]/div[2]/div/div[2]/div[2]/div[1]/div/div/div/div[2]",10);
            dInstructions.clickElementWhenClickable(driver, loadEnterAnimations);
        }
        public void loadMiddleAnimations(WebDriver driver)
        { 
            IWebElement loadMiddleAnimationsButton=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[1]/div[3]/div/div[5]/div[1]/div[2]/div/div[2]/div[2]/div[1]/div/div/div/button",10);
            dInstructions.clickElementWhenClickable(driver, loadMiddleAnimationsButton);

            IWebElement loadMiddleAnimations=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[1]/div[3]/div/div[5]/div[1]/div[2]/div/div[2]/div[2]/div[1]/div/div/div/div[3]",10);
            dInstructions.clickElementWhenClickable(driver, loadMiddleAnimations);
        }
        public void loadExitAnimations(WebDriver driver)
        { 
            IWebElement loadExitAnimations=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[1]/div[1]/div[3]/div/div[5]/div[1]/div[2]/div/div[2]/div[2]/div[1]/div/div/div/div[4]",10);
            dInstructions.clickElementWhenClickable(driver, loadExitAnimations);
        }

        public void applyEnterAnimation(WebDriver driver, string effect)
        {
            IWebElement rotate=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[6]/div[1]/div/i[1]",10);
            IWebElement scaleUp=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[6]/div[1]/div/i[2]",10);
            IWebElement scaleDown=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[6]/div[1]/div/i[3]",10);
            IWebElement flipX=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[6]/div[1]/div/i[4]",10);
            IWebElement styleNone=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[6]/div[1]/div/i[5]",10);
            IWebElement flipY=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[6]/div[1]/div/i[6]",10);
            IWebElement fade=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[6]/div[1]/div/i[7]",10);
            IWebElement move=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[6]/div[1]/div/i[8]",10);

            IWebElement fromTopLeft=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[6]/div[2]/div/i[1]",10);
            IWebElement fromTop=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[6]/div[2]/div/i[2]",10);
            IWebElement fromTopRight=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[6]/div[2]/div/i[3]",10);
            IWebElement fromLeft=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[6]/div[2]/div/i[4]",10);
            IWebElement directionNone=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[6]/div[2]/div/i[5]",10);
            IWebElement fromRight=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[6]/div[2]/div/i[6]",10);
            IWebElement fromBottomLeft=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[6]/div[2]/div/i[7]",10);
            IWebElement fromBottom=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[6]/div[2]/div/i[8]",10);
            IWebElement fromBottomRight=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[6]/div[2]/div/i[9]",10);

            IWebElement normalIn=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[6]/div[3]/div/i[1]",10);
            IWebElement normalOut=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[6]/div[3]/div/i[2]",10);
            IWebElement elasticOut=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[6]/div[3]/div/i[3]",10);
            IWebElement bounceOut=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[6]/div[3]/div/i[4]",10);
            IWebElement easingNone=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[6]/div[3]/div/i[5]",10);
            IWebElement backIn=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[6]/div[3]/div/i[6]",10);
            IWebElement backOut=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[6]/div[3]/div/i[6]",10);
            IWebElement circularIn=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[6]/div[3]/div/i[7]",10);
            IWebElement circularOut=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[6]/div[3]/div/i[8]",10);

            switch(effect.ToLower()) 
            {
                case "rotate":
                rotate.Click();
                break;
                case "scaleup":
                scaleUp.Click();
                break;
                case "scaledown":
                scaleDown.Click();
                break;
                case "flipx":
                flipX.Click();
                break;
                case "stylenone":
                styleNone.Click();
                break;
                case "flipy":
                flipY.Click();
                break;
                case "fade":
                fade.Click();
                break;
                case "move":
                move.Click();
                break;
                case "fromtopleft":
                fromTopLeft.Click();
                break;
                case "fromtop":
                fromTop.Click();
                break;
                case "fromtopright":
                fromTopRight.Click();
                break;
                case "fromleft":
                fromLeft.Click();
                break;
                case "directionnone":
                directionNone.Click();
                break;
                case "fromright":
                fromRight.Click();
                break;
                case "frombottomleft":
                fromBottomLeft.Click();
                break;
                case "frombottom":
                fromBottom.Click();
                break;
                case "frombottomright":
                fromBottomRight.Click();
                break;
                case "normalin":
                normalIn.Click();
                break;
                case "normalout":
                normalOut.Click();
                break;
                case "elasticout":
                elasticOut.Click();
                break;
                case "bounceout":
                bounceOut.Click();
                break;
                case "easingnnone":
                easingNone.Click();
                break;
                case "backin":
                backIn.Click();
                break;
                case "backout":
                fromBottomLeft.Click();
                break;
                case "backOut":
                fromBottom.Click();
                break;
                case "circularin":
                circularIn.Click();
                break;
                case "circularout":
                circularOut.Click();
                break;
                default:
                break;
            }
        }

        public void applyMiddleAnimations(WebDriver driver, string effect, int repeat)
        {
            IWebElement scaleDown=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[6]/div[1]/div/i[1]",10);
            IWebElement scaleUp=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[6]/div[1]/div/i[2]",10);
            IWebElement fade=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[6]/div[1]/div/i[3]/span[12]",10);
            IWebElement shake=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[6]/div[1]/div/i[4]",10);
            IWebElement repeatUp=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[6]/div[2]/div/div/div/div[1]/i",10);
            IWebElement repeatDown=dInstructions.getElementAfterWaitXP(driver,"/html/body/div[6]/div[2]/div/div/div/div[2]/i",10);

            switch(effect.ToLower()) 
            {
                case "scaledown":
                scaleDown.Click();
                break;
                case "scaleup":
                scaleUp.Click();
                break;
                case "fade":
                fade.Click();
                break;
                case "shake":
                shake.Click();
                break;
                default:
                break;
            }

            if(repeat<0)
            {
                //convert negative int to positive
                repeat=0-repeat;
                for(int i = 0; i <= repeat;i++)
                {
                    repeatDown.Click();
                }
            }
            else
            {
                for(int i = 0; i <= repeat;i++)
                {
                    repeatUp.Click();
                }
            }

        }
    }
} 
