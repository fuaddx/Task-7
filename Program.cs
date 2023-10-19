using System.Reflection.Metadata;

namespace Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Username:");
            string Username = Console.ReadLine();
            Console.WriteLine("Enter Password: ");
            int Password=   Convert.ToInt32(Console.ReadLine());
            User user = new User(Username, Password, false, true);
            user.Login();
            user.Logout();
        }
    }

    class User
    {
        //field 
        public string Username;
        public int Password;
        public bool IsLoggedin;
        public bool IsLoggout;

        //property
        public User(string Username, int Password, bool IsLoggedin, bool IsLoggout)
        {

            this.Username = Username;
            this.Password = Password;
            this.IsLoggedin = IsLoggedin;
            this.IsLoggout = IsLoggout;
        }

        //methods

        public void Login()
        {

            if (IsLoggedin)
            {
                Console.WriteLine($"{Username} logged in account ");
            }
            else
            {
                Console.WriteLine($"{Username} left the account");
            }
        }
        public void Logout()
        {
            if (IsLoggout)
            {
                
                Console.WriteLine($"{Username} has logged in account since 1 min ago ");
            }
            else
            {
                Console.WriteLine($"{Username} has never logged in account");
            }
        }

    }

}