using SeleniumTraining.src.code.page.yop;
using SeleniumTraining.src.code.page.yopUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining.src.code.Tasks.TaskYop
{
    public class Email
    {
        private const string frameMail = "ifmail";
        private const string frameMsg = "ifinbox";
        private const string contentMsgAlert = "Your message has been sent";
        public static void EditNew()
        {
            Thread.Sleep(3000);
            Click.On(EmailUI.newEmailBtn);
        }

        public static void goFrame(string frame)
        {
            WaitUntil.waitForSeconds(2000);
            WaitUntil.waitUntilFrameIsAvailableToSwitchToIt(frame);
        }

        public static void FillRecipient(string text)
        {
            goFrame(frameMail);
            Enter.Text(MessageUI.toBox, text);
        }

        public static void FillSubject(string text)
        {
            Enter.Text(MessageUI.subjectBox, text);
        }

        public static void SetMsgBody(string text)
        {
            Enter.Text(MessageUI.msgBody, text);
        }
        public static void clickBtnSend()
        {
            Click.On(MessageUI.sendBtn);
        }

        public static void validateMsgSent() {
            WaitUntil.waitForSeconds(2000);
            string textToValidate = MessageUI.msgSent.getText();
            Assert.IsNotNull(textToValidate);
            Assert.IsTrue(textToValidate.Contains(contentMsgAlert));
        }

        public static void validateContainsEmailArrived(string email, string subject) {
            goFrame(frameMsg);
            string emailUi = EmailUI.emailUiEnter.getText();
            string subjectUi = EmailUI.subjectUiEnter.getText();
            Assert.IsNotNull(email);
            Assert.IsNotNull(subject);
            Assert.IsTrue(emailUi.Contains(email));
            Assert.IsTrue(subjectUi.Contains(subject));
        }

        public static void clickRefreshEmail()
        {
            WaitUntil.switchToMainContent();
            WaitUntil.waitForSeconds(1000);
            Click.On(EmailUI.refreshEmailBtn);
        }
    }
}
