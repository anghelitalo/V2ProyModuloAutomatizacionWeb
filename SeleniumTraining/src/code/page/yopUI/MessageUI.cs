using OpenQA.Selenium;
using SeleniumTraining.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining.src.code.page.yopUI
{
    public class MessageUI
    {
        public static TextBox toBox = new TextBox(By.XPath("//input[@id='msgto']"));
        public static TextBox subjectBox = new TextBox(By.XPath("//input[@id='msgsubject']"));
        public static TextBox msgBody = new TextBox(By.XPath("//div[@id='msgbody']"));
        public static Button sendBtn = new Button(By.XPath("//button[@id='msgsend']"));
        public static TextBox msgSent = new TextBox(By.XPath("//div[@id='msgpopmsg']"));
    }
}
