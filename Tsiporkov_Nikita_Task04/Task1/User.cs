﻿using System;
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
        private DateTime dateOfBirth;
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
                if (Regex.IsMatch(value, "(\\A[A - Z][a - z] +\\Z) | (\\A[А - Я][а - я] +\\Z)"))
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
                if (Regex.IsMatch(value, "(\\A[A - Z][a - z] +\\Z) | (\\A[А - Я][а - я] +\\Z)"))
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
                int age = 0;
                if (DateTime.Today.Month < dateOfBirth.Month)
                {
                    age = DateTime.Today.Year - dateOfBirth.Year-1;
                }
                else
                {
                    age = DateTime.Today.Year - dateOfBirth.Year;
                }
                return age;
            }
        }
    }
}