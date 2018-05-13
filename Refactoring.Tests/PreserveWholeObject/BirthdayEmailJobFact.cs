using Refactoring.PreserveWholeObject;
using Xunit;

namespace Refactoring.Tests.PreserveWholeObject
{
    public class BirthdayEmailJobFact
    {
        [Fact]
        public void should_send_email_to_birthday_employee()
        {
            var birthdayEmailJob = new BirthdayEmailJob();
            var birthdayEmployee = birthdayEmailJob.GetBirthdayEmployee();
            var sendEmail = birthdayEmailJob.SendBirthdayEmail(birthdayEmployee.FirstName, birthdayEmployee.LastName, birthdayEmployee.Email);
            Assert.Equal("system", sendEmail.From);
            Assert.Equal(birthdayEmployee.Email, sendEmail.To);
            Assert.Equal(birthdayEmployee.GetFullName(), sendEmail.Title);
            Assert.Equal("Happy Birthday", sendEmail.Content);
        }
    }
}