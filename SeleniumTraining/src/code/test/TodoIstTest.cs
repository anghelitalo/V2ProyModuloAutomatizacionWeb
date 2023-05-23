using SeleniumTraining.src.code.Tasks.TaskTodo;
using SeleniumTraining.src.code.Tasks.TaskYop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining.src.code.test
{
    [TestClass]
    public class TodoIstTest : TestBase
    {
        private const string url = "https://todoist.com/";
        private const string user = "elianorlopezhurtado83@gmail.com";
        private const string password = "200105574";

        [TestInitialize]
        public void SetUp()
        {
            session.Session.Instance().GetBrowser().Navigate().GoToUrl(url);
            LoginTodo.As(user, password);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow("test1", "test2")]
        public void validateCrudProject(string nameProject, string nameProjectEdit) {
            Project.AddProjectClick();
            Project.setProjectName(nameProject);
            Project.editProjectName(nameProject, nameProjectEdit);
            Project.deleteProjectName(nameProjectEdit);
        }
    }
}
