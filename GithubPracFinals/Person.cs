﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GithubPracFinals
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person(string firstName, string lastName, int age)
        { 
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string GetFullName()
        {
            string fullName = FirstName + " " + LastName;
            return fullName;
        }

        public void DisplayInfo()
        {
            Console.WriteLine(FirstName + " " + LastName);
            Console.WriteLine(Age);
        }
    }
}
