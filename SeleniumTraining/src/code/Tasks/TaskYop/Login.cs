using OpenQA.Selenium;
using SeleniumTraining.src.code.page.yop;
using SeleniumTraining.src.code.page.yopUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining.src.code.Tasks.TaskYop
{
    public class Login
    {
        public static void As(string user) { 
            Enter.Text(LoginUI.loginBox,user);
            Click.On(LoginUI.goButton);
        }
    }
}
