using Homework3.Users;

namespace Homework3.Applications
{
    public class Application
    {
        private ApplicationView _applicationView;

        private string _createUserCommand;
        private string _showUsersCountCommand;
        private string _exitCommand;

        public Application()
        {
            _applicationView = new ApplicationView();

            _createUserCommand = _applicationView.CreateUserCommand;
            _showUsersCountCommand = _applicationView.ShowUsersCountCommand;
            _exitCommand = _applicationView.ExitCommand;
        }

        public void Run()
        {
            bool isRunning = true;

            while (isRunning)
            {
                _applicationView.ShowMenu();
                string userInput = _applicationView.GetUserInput();

                if (userInput == _createUserCommand)
                {
                    string userRole = _applicationView.GetUsersRole();
                    User user = UserFactory.CreateUser(userRole);
                }
                else if (userInput == _showUsersCountCommand)
                {
                    _applicationView.ShowUsersCount();
                }
                else if (userInput == _exitCommand)
                {
                    isRunning = false;
                }
                else
                {
                    _applicationView.ShowInvalidCommandMessage();
                }
            }
        }
    }
}
