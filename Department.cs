using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{

     class Department
    {
       public string Name;
       private int _salaryLimit;
       private int _employeLimit;
       public Employee [] employees = new Employee[0];





        public int SalaryLimit
        {
            get
            {
                return this._salaryLimit;
            }
            set
            {
                if (value > 350 && value <1000)
                {
                    this._salaryLimit = value;
                }
            }
        }


        public int EmployeLimit
        {
            get
            {
                return this._employeLimit;
            }
            set
            {
                if (value >1 && value < 6)
                {
                    this._employeLimit = value;
                }
            }
        }

        public void AddEmployeToArr(Employee employees)
        {
            if (this.employees.Length < this._employeLimit)
            {
                Array.Resize(ref this.employees, this.employees.Length + 1);
                this.employees[this.employees.Length - 1] = employees;
            }
            else
            {
                throw new Exception("200 iwchi choxdu ,onu 100 ele maawida 20 faiz artir :)");
            }

        }
















    }
}
