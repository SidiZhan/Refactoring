using Refactoring.RemoveControlFlag;
using Xunit;

namespace Refactoring.Tests.RemoveControlFlag
{
    public class UserFact
    {
        [Fact]
        public void should_get_admin_user_name()
        {
            var userController = new UserController();
            Assert.Equal("adminName", userController.GetAdminUserName());
        }

        [Fact]
        public void should_send_reminder()
        {
            var userController = new UserController();
            var userName = "userName";
            var user = new User
            {
                Name = userName,
                Role = "admin"
            };
            userController.SendReminder(user);
            Assert.Equal($"{userName}(admin)", userController.Mail.To);
        }
    }
}