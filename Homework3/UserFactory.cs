using Homework3.Users;

namespace Homework3
{
    public static class UserFactory
    {
        private static int _clientCount;
        private static int _adminCount;
        private static int _managerCount;

        public static User CreateUser(string role)
        {
            switch (role)
            {
                case "Клиент":
                    _clientCount++;
                    return new Client();

                case "Администратор":
                    _adminCount++;
                    return new Admin();

                case "Менеджер":
                    _managerCount++;
                    return new Manager();

                default:
                    return null;
            }
        }

        public static string GetCountUsers()
        {
            return $"Клиент - {_clientCount}, Администратор - {_adminCount}, Менеджер - {_managerCount}.";
        }
    }
}
