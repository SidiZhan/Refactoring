using System.Collections.Generic;

namespace Refactoring.RemoveControlFlag
{
    public class UserController
    {
        public Mail Mail { get; set; }
        void SendReminder(Mail mail)
        {
            Mail = mail;
        }

        List<User> GetUserList()
        {
            return new List<User>
            {
                new User
                {
                    Name = "normalName",
                    Role = "general"
                },
                new User
                {
                    Name = "adminName",
                    Role = "admin"
                }
            };
        }

        public string GetAdminUserName()
        {
            string adminName = "";
            foreach (var user in GetUserList())
            {
                if (adminName.Equals(""))
                {
                    if (user.Role.Equals("admin"))
                    {
                        adminName = user.Name;
                    }
                }
            }
            return adminName;
        }

        public void SendReminder(User user)
        {
            if (user.Role.Equals("admin"))
            {
                var from = "system";
                var to = $"{user.Name}(admin)";
                var subject = "subject";
                var body = "body";

                SendReminder(new Mail
                {
                    From = from,
                    To = to,
                    Subject = subject,
                    Body = body
                });
            }
            else
            {
                var from = "system";
                var to = user.Name;
                var subject = "subject";
                var body = "body";

                SendReminder(new Mail
                {
                    From = from,
                    To = to,
                    Subject = subject,
                    Body = body
                });
            }
        }
    }
}