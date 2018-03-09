using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class User
    {
        private string name;
        private string surname;
        private string patronymic;
        private string birthday;
        private int age;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (Regex.IsMatch(value, "(\\A[A - Z][a - z] +\\Z) | (\\A[А - Я][а - я] +\\Z)"))
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Wrong Name");
                }
            }
        }
        public string SurName
        {
            get
            {
                return surname;
            }
            set
            {
                if (Regex.IsMatch(value, "(\\A[A - Z][a - z] +\\Z) | (\\A[А - Я][а - я] +\\Z)"))
                {
                    surname = value;
                }
                else
                {
                    Console.WriteLine("Wrong Surname");
                }
            }
        }
        public string Patronymic
        {
            get
            {
                return patronymic;
            }
            set
            {
                if (Regex.IsMatch(value, "(\\A[A - Z][a - z] +\\Z) | (\\A[А - Я][а - я] +\\Z)"))
                {
                    patronymic = value;
                }
                else
                {
                    Console.WriteLine("Wrong patronymic");
                }
            }
        }
        public string Birthday
        {
            get
            {
                return birthday;
            }
            set
            {
                if (Regex.IsMatch(value, "^(((0[1-9]|[12]\\d|3[01])\\.(0[13578]|1[02])\\.((19|[2-9]\\d)\\d{2}))|" +
                    "((0[1-9]|[12]\\d|30)\\.(0[13456789]|1[012])\\.((19|[2-9]\\d)\\d{2}))|((0[1-9]|1\\d|2[0-8])\\.02\\." +
                    "((19|[2-9]\\d)\\d{2}))|(29\\.02\\.((1[6-9]|[2-9]\\d)(0[48]|[2468][048]|[13579][26])|" +
                    "((16|[2468][048]|[3579][26])00))))$"))
                {
                    birthday = value;
                }
                else
                {
                    Console.WriteLine("Wrong date of birthday");
                }
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 0 && value < 100)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Wrong age");
                }
            }
        }
    }
}