using Microsoft.VisualBasic;
using OpenQA.Selenium;
using SeleniumTraining.src.code.control;
using SeleniumTraining.src.code.page;
using SeleniumTraining.src.code.page.todoUI;
using SeleniumTraining.src.code.page.yop;
using SeleniumTraining.src.code.page.yopUI;
using SeleniumTraining.src.code.Tasks.TaskYop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining.src.code.Tasks.TaskTodo
{
    public class Project
    {
        private const string titleConfirmDelete = "Delete project?";

        public static void AddProjectClick(){
            Click.On(ProjectUI.goProjectMenuBtn);
            Click.On(ProjectUI.addProjectMenuBtn);
        }

        public static void setProjectName(string name) {
            Enter.Text(ProjectUI.nameBox,name);
            Click.On(ProjectUI.addDialogBtn);
            Assert.IsNotNull(ProjectUI.liElementProject);
        }

        public static void editProjectName(string name, string namereplace) {
            clickOnProject(name);
            Click.On(ProjectUI.editProjectMenuBtn);
            Assert.IsTrue(ProjectUI.titleEditBox.IsControlDisplayed());
            
            Enter.Text(ProjectUI.nameToEditBox, namereplace);
            Click.On(ProjectUI.addDialogBtn);
            WaitUntil.waitForSeconds(2000);
            string nameProj = "//span[text()='name']".Replace("name", namereplace);
            Label nameProjExist = new Label(By.XPath(nameProj));
            string nameValid = nameProjExist.getText();
            WaitUntil.waitForSeconds(2000);
            Assert.IsNotNull(nameProjExist);
            Assert.IsNotNull(nameValid);
            Assert.IsTrue(nameValid.Contains(namereplace));
        }

        public static void deleteProjectName(string name) {
            clickOnProject(name);
            Click.On(ProjectUI.deleteProjectMenuBtn);
            WaitUntil.waitForSeconds(2000);
            //valid delete project
            string titleConfirm = ProjectUI.titleDeleteConfirm.getText();
            Assert.IsTrue(titleConfirm.Contains(titleConfirmDelete));
            Click.On(ProjectUI.addDialogBtn);
            WaitUntil.waitForSeconds(2000);
            string nameProj = "//span[text()='name']".Replace("name", name);
            Label nameProjExist = new Label(By.XPath(nameProj));
            Assert.IsFalse(nameProjExist.IsControlDisplayed(),
               "ERROR !! project exists.");
        }

        protected static void clickOnProject(string name) {
            string nameToEdit = "(//button[@aria-label='More project actions'])[3][//span[text()='NAMEPRO']]";
            string nameToReplace = nameToEdit.Replace("NAMEPRO", name);

            Button projNameBtn = new Button(By.XPath(nameToReplace));

            Click.On(ProjectUI.goProjectMenuBtn);
            Click.On(projNameBtn);
            Assert.IsNotNull(ProjectUI.liElementProject);
        }
    }
}
