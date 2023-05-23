using OpenQA.Selenium;
using SeleniumTraining.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining.src.code.page.todoUI
{
    public class ProjectUI
    {
        public static Button goProjectMenuBtn = new Button(By.XPath("//a[contains(@href,'/app/projects')]"));
        public static Button addProjectMenuBtn = new Button(By.XPath("//button[@aria-label='Add project']"));

        //dialog project
        public static TextBox nameBox = new TextBox(By.XPath("//input[@id='edit_project_modal_field_name']"));
        
        public static Button submitProjectAdd = new Button(By.XPath("//span[text()='Add']")); //to edit same button
        public static Button addDialogBtn = new Button(By.XPath("//button[@type='submit']"));

        public static Button editProjectMenuBtn = new Button(By.XPath("//div[contains(text(),'Edit project')]"));

        public static TextBox titleEditBox = new TextBox(By.XPath("//h1[@id='project-modal-title']"));

        //edit project dialog
        public static TextBox nameToEditBox = new TextBox(By.XPath("//input[@id='edit_project_modal_field_name']"));

        //delete project from menu
        public static Button deleteProjectMenuBtn = new Button(By.XPath("//div[contains(text(),'Delete project')]"));
        public static Label titleDeleteConfirm = new Label(By.XPath("//h1[@id='confirm-dialog-title']"));
       

        //project list
        public static TextBox liElementProject = new TextBox(By.XPath("//ul[@id= 'projects_list'][count(li[@data-type='project_list_item']) > 2]"));

    }
}
