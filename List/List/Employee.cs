﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace List
{
    class Employee
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }


        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public Employee(int id, string name)
        {
            Id= id;
            Name = name;
        }

        public void increaseSalary(double percentage)
        {
            Salary = (Salary * (percentage / 100)) + Salary;

        }

        public override string ToString()
        {
            return Id + ", " + Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
