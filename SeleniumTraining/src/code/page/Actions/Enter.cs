using OpenQA.Selenium;
using SeleniumTraining.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining.src.code.page.yop
{
    public static class Enter
    {
        public static void Text(TextBox locator, string text) { 
            locator.SetText(text);
        }
    }
}
