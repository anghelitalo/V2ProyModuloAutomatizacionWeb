using OpenQA.Selenium;
using SeleniumTraining.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining.src.code.page.todoUI
{
    public class DeleteDialogUI
    {
        //dialog project
        public static TextBox textTitleBox = new TextBox(By.XPath("//h1[@id='confirm-dialog-title']"));
        public static Button submitDelete = new Button(By.XPath("//span[text()='Delete']"));
    }
}
