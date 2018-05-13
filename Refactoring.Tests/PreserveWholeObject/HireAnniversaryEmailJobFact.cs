using Refactoring.PreserveWholeObject;
using Xunit;

namespace Refactoring.Tests.PreserveWholeObject
{
    public class HireAnniversaryEmailJobFact
    {
        [Fact]
        public void should_send_email_to_birthday_employee()
        {
            var hireAnniversaryEmailJob = new HireAnniversaryEmailJob();
            var anniversaryEmployee = hireAnniversaryEmailJob.GetAnniversaryEmployee();
            var sendEmail = hireAnniversaryEmailJob.SendAnniversaryEmail(anniversaryEmployee, 1);
            Assert.Equal("system", sendEmail.From);
            Assert.Equal(anniversaryEmployee.Email, sendEmail.To);
            Assert.Equal(anniversaryEmployee.GetFullName(), sendEmail.Title);
            Assert.Equal("This is the 1th years", sendEmail.Content);
        }
    }
}