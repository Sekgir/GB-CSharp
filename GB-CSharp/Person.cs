using System;
using System.Collections.Generic;
using System.Text;

namespace GB_CSharp
{
    [Serializable]
    class Person
    {
        public string FullName { get; set; }
        public string Post { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public double Wage { get; set; }
        public int Age { get; set; }

        public Person(string fullName, string post, string email, string phone, double wage, int age)
        {
            FullName = fullName;
            Post = post;
            Email = email;
            Phone = phone;
            Wage = wage;
            Age = age;
        }
        public void OutputInfo()
        {
            Console.WriteLine($"ФИО: {FullName + Environment.NewLine}должность: {Post + Environment.NewLine}email: {Email + Environment.NewLine}" +
                $"телефон: {Phone + Environment.NewLine}зарплата: {Wage + Environment.NewLine}возраст: {Age}");
        }
    }
}
