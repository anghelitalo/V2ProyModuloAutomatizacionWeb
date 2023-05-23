using OpenQA.Selenium;
using SeleniumTraining.src.code.session;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining.src.code.control
{
    public class ControlSelenium
    {
        protected By locator;
        protected IWebElement control;

        public ControlSelenium(By locator) 
        {
            this.locator = locator;
        }

        protected void FindControl() 
        {
            control = Session.Instance().GetBrowser().FindElement(locator);
        }

        public void Click() 
        { 
            FindControl();
            control.Click();
        }

        public Boolean IsControlDisplayed()
        {
            try
            {
                FindControl();
                return control.Displayed;
            }catch (Exception ex)
            {
                return false;
            }
        }

        public String getText() {
            try
            {
                FindControl();
                return control.Text.ToString();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}
