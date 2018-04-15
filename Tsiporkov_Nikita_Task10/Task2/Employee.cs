using System;
using System.Text.RegularExpressions;
using ClassLibrary1;

namespace Task2
{
    class Employee : User , IEquatable<Employee>
    {
        private DateTime startOfWork;
        private int lengthOfWork;
        private string post;
        public Employee(string name, string surname, DateTime dateOfBirth, int lengthOfWork, string post, string patronymic = null)
            : base(name, surname, dateOfBirth, patronymic = null)
        {
            LengthOfWork = lengthOfWork;
            Post = post;
        }
        public int LengthOfWork
        {
            get
            {
                return lengthOfWork + (Class1.GetNumber(startOfWork));
            }
            set
            {
                if (value >= 0)
                {
                    lengthOfWork = value;
                }
                else
                {
                    throw new ArgumentException("Invalid number");
                }
            }
        }
        public DateTime StartWork
        {
            get { return startOfWork; }
            set
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentException("Date invalid.");
                }
                else
                {
                    startOfWork = value;
                }
            }
        }
        public string Post
        {
            get { return post; }
            set
            {
                if (Regex.IsMatch(value, "(\\A[A - Z][a - z] +\\Z) | (\\A[А - Я][а - я] +\\Z)"))
                {
                    post = value;
                }
                else
                {
                    throw new ArgumentException("Post cannot be empty.");
                }
            }
        }

        public bool Equals(Employee other)
        {
            return base.Equals(other) && LengthOfWork==other.LengthOfWork && Post.Equals(other.Post);
        }
    }
}