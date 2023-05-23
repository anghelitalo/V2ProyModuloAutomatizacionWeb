using SeleniumTraining.src.code.page.todoUI;
using SeleniumTraining.src.code.page.yop;

namespace SeleniumTraining.src.code.Tasks.TaskTodo
{
    public class LoginTodo
    {
        public static void As(string user, string password)
        {
            Click.On(LoginUI.goButtonLogin);
            Enter.Text(LoginUI.emailBox, user);
            Enter.Text(LoginUI.passBox, password);
            Click.On(LoginUI.submitLogin);
            WaitUntil.waitForSeconds(4000);
        }
    }
}
