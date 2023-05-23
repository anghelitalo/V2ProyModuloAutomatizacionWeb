using OpenQA.Selenium;
using SeleniumTraining.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining.src.code.page.yopUI
{
    public class EmailUI
    {
        public static Button newEmailBtn = new Button(By.XPath("//button[@id='newmail']"));
        public static Button refreshEmailBtn = new Button(By.XPath("//button[@id='refresh']"));
        public static TextBox emailUiEnter = new TextBox(By.XPath("(//span[@class='lmf'])[1]"));
        public static TextBox subjectUiEnter = new TextBox(By.XPath("(//div[@class='lms'])[1]"));
    }
}
