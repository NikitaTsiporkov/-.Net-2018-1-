﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter name of user: ");
            string userName =Console.ReadLine();
            User user = new User();
            user.Birthday = userName;
            Console.WriteLine(user.Birthday);
            Console.ReadKey();
        }
    }
}