using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person
    {
        public string Fullname { get; set; }
        public string Name { get; set; }

        public string Lastname { get; set; }

        public string email { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person user = new Person
            {
                Fullname = "Хоменко",
                Name = "Владимир",
                Lastname = "Алексеевич",
                email = "homenko_vova67@mail.ru",
            };

            Console.WriteLine("Имя пользователя: " + " " + user.Fullname + " " + user.Name + " " + user.Lastname);
            Console.WriteLine($"Электронная почта: {user.email}");
            Console.ReadLine();
        }
    }
}
