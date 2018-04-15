using System;
using System.Text.RegularExpressions;

namespace Task2
{
    public class User : IEquatable<User>
    {
        private string name;
        private string surname;
        private DateTime dateOfBirth;
        private int age;
        public User(string name, string surname, DateTime dateOfBirth, string patronymic = null)
        {
            Name = name;
            SurName = surname;
            Patronymic = patronymic;
            DateOfBirth = dateOfBirth;
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (Regex.IsMatch(value, "(\\b[A-ZА-Я][a-zа-я]+\\b)"))
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException("Name cannot be empty.");
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
                if (Regex.IsMatch(value, "\\b[A-ZА-Я][a-zа-я]+\\b"))
                {
                    surname = value;
                }
                else
                {
                    throw new ArgumentException("SurName cannot be empty.");
                }
            }
        }
        public string Patronymic
        {
            get;
            set;
        }
        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentException("Date invalid.");
                }
                else
                {
                    dateOfBirth = value;
                }
            }
        }
        public int Age
        {
            get
            {
                age = ClassLibrary1.Class1.GetNumber(dateOfBirth);
                return age;
            }
        }

        public virtual bool Equals(User other)
        {
            if (other == null)
            {
                throw new ArgumentException("Invalid user");
            }
            return Name.Equals(other.Name) && SurName.Equals(other.SurName) && DateOfBirth.Equals(other.DateOfBirth);
        }
    }
}