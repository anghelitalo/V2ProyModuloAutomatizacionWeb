using OpenQA.Selenium;
using SeleniumTraining.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining.src.code.page.yopUI
{
    public static class LoginUI
    {
        public static TextBox loginBox = new TextBox(By.XPath("//input[@id='login']"));
        public static Button goButton = new Button(By.XPath("//button[@class='md']"));

    }
}
