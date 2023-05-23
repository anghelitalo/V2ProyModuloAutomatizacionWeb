using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;
using SeleniumTraining.src.code.session;

namespace SeleniumTraining.src.code.page.yop
{
    public class WaitUntil
    {
        public static void waitUntilFrameIsAvailableToSwitchToIt(string frame)
        {
            IWebDriver driver = session.Session.Instance().GetBrowser();
            try
            {
                 driver.SwitchTo().Frame(frame);
            }
            catch (NoSuchFrameException)
            {
                Console.WriteLine("error driver");
            }
        }

        public static Func<IWebDriver, IWebDriver> FrameToBeAvailableAndSwitchToIt(string frameLocator)
        {
            return (driver) =>
            {
                try
                {
                    return driver.SwitchTo().Frame(frameLocator);
                }
                catch (NoSuchFrameException)
                {
                    return null;
                }
            };
        }

        public static void switchToMainContent()
        {
            IWebDriver driver = session.Session.Instance().GetBrowser();
            try
            {
                driver.SwitchTo().DefaultContent();
            }
            catch (NoSuchFrameException)
            {
                Console.WriteLine("error driver");
            }
        }

        public static void waitForSeconds(int sec)
        {
            try
            {
                Thread.Sleep(sec);
            }
            catch (TimeoutException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
