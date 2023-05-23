using OpenQA.Selenium;
using SeleniumTraining.src.code.control;
using SeleniumTraining.src.code.page.yopUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining.src.code.page.yop
{
    public static class Click
    {
        public static void On (Button locator){
            locator.Click ();
        }       
    }
}
