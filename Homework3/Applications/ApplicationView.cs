namespace Homework3.Applications
{
    public class ApplicationView
    {
        public string CreateUserCommand { get; } = "1";
        public string ShowUsersCountCommand { get; } = "2";
        public string ExitCommand { get; } = "3";

        private Dictionary<string, string> _commands;

        public ApplicationView()
        {
            _commands = new Dictionary<string, string>()
            {
                { CreateUserCommand, "Добавить пользователя" },
                { ShowUsersCountCommand, "Показать количество пользователей" },
                { ExitCommand, "Выйти" }
            };
        }

        public void ShowMenu()
        {
            foreach (KeyValuePair<string, string> command in _commands)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"{command.Value} - {command.Key}");
                Console.ResetColor();
            }
        }

        public void ShowUsersCount()
        {
            Console.WriteLine(UserFactory.GetCountUsers());
        }

        public void ShowInvalidCommandMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Неверная команда!");
            Console.ResetColor();
        }

        public string GetUserInput()
        {
            return Console.ReadLine();
        }

        public string GetUsersRole()
        {
            return Console.ReadLine();
        }
    }
}
