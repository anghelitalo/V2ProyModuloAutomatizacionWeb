using SeleniumTraining.src.code.Tasks.TaskYop;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining.src.code.test
{
    [TestClass]
    public class EmailYopMailTest : TestBase
    {
        private const string url = "https://yopmail.com/";
        private const string user = "anghelitalo";

        [TestInitialize]
        public void SetUp()
        {
            session.Session.Instance().GetBrowser().Navigate().GoToUrl(url);
            Login.As(user);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow("anghelitalo@yopmail.com", "test1", "test body")]
        public void VerifyEmailSend(string email, string subject, string msg)
        {
            Email.EditNew();
            Email.FillRecipient(email);
            Email.FillSubject(subject);
            Email.SetMsgBody(msg);
            Email.clickBtnSend();
            Email.validateMsgSent();
            Email.clickRefreshEmail();
            Email.validateContainsEmailArrived(email, subject);
        }
    }
}
