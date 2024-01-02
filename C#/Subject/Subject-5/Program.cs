using System;
using System.Linq;

namespace ConsoleApp
{

    class Person
    {
        string _name;
        public string Name
        {
            get {
                return _name;
            }
            set {
                if(value.Length>15)
                    throw new Exception("Name için en fazla 15 karakter girmelisiniz.");
                _name = value;
            }
        }
    }
    class Program
    {
        static void check_password(string password)
        {
            if (password.Length<8 || password.Length>15)
                throw new Exception("Parola 7-15 karakter arasında olmalıdır.");
            if (!password.Any(char.IsDigit))
                throw new Exception("Parola en az bir rakam içermelidir.");
            if (!password.Any(char.IsLetter))
                throw new Exception("Parola en az bir harf içermelidir");
        }

        static void Main(string[] args)
        {
            // Exception Handling

            // string parola = "12345222s";

            // try
            // {
            //     check_password(parola);
            //     Console.WriteLine("parola geçerli.");
            // }
            // catch (Exception ex)
            // {
            //     Console.WriteLine(ex.Message);
            // }
           

            try
            {
                var p = new Person();
                p.Name = "Sadık                                    ";
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

         
        }


    }
}
