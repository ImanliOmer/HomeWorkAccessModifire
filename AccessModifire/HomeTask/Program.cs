using HomeTask.Model;
using System;

namespace HomeTask
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the username: ");
            string username = Console.ReadLine();

            Console.Write("Please enter the password: ");
            string password = Console.ReadLine();

            Console.Write("Please enter the age: ");
            int age = int.Parse(Console.ReadLine());




            User user1 = new User(username, password);

            user1.Info();
            user1.Age = age;
           



        }
    }
}
