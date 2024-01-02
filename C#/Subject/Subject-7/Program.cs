using System;

namespace ConsoleApp
{    
  
    // Exception

    // IndexOutOfRangeException => dizi sınırı aşma durumunda
    // Login => username, password

    class LoginException: Exception
    {
        public LoginException(string message):base(message)
        {
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Login("yagizcan","123456777");
                Console.WriteLine("login başarılı.");
            }
            catch (LoginException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        static void Login(string username, string password)
        {
            if (username.Contains(" "))
                throw new LoginException("username boşluk içeremez.");

            if (password.Length<8)
                throw new LoginException("Parola min. 8 karakter olmalıdır.");
        }
    }
}
