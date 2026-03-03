namespace Homework3
{
    public abstract class User
    {
        private string _role;

        public User(string role)
        {
            _role = role;
        }

        public string GetRole()
        {
            return _role;
        }
    }
}
