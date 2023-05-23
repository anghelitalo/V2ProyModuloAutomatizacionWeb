using OpenQA.Selenium;
using SeleniumTraining.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining.src.code.page.todoUI
{
    public class LoginUI
    {
        public static Button goButtonLogin = new Button(By.XPath("//a[contains(@href,'/auth/login')]"));
        public static TextBox emailBox = new TextBox(By.XPath("//input[@id='element-0']"));
        public static TextBox passBox = new TextBox(By.XPath("//input[@id='element-3']"));
        public static Button submitLogin = new Button(By.XPath("//button[@type='submit']"));
    }
}
