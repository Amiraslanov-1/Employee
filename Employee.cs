using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Employee
    {
        private string _name;
        private string _surname;
        private double _salary;



        public string Name
        {
            get => this._name;
            set
            {
                if (checkName(value))
                    this._name = value;
            }
        }
        public string Surname
        {
            get => this._surname;
            set
            {
                if (checkName(value))
                    this._surname = value;
            }
        }
        public double Salary
        {
            get => this._salary;
            set
            {
                if (value< 251 && value>10)
                    this._salary = value;
            }
        }



        static bool checkName(string Name)
        {

            if (!string.IsNullOrWhiteSpace(Name) && Name.Length < 20 && char.IsUpper(Name[0]))
            {
                for (int i = 0; i < Name.Length; i++)
                {
                    if (!char.IsLetter(Name[i]))
                    {
                        return false;
                    }
                }
                return true;

            }
            return false;
        }
       






    }
}
