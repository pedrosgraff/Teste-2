using System;
using System.Globalization;
using System.Collections.Generic;

namespace List
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de pessoas: ");
            int qtd = int.Parse(Console.ReadLine());
            int id;
            string name;
            double salary;
            int percentage;

            List<Employee> list = new List<Employee>();


            for (int i = 0; i < qtd; i++)
            {
                Console.WriteLine("Emplyoee #" + (i + 1) + ":");
                Console.Write("Write the Id: ");
                id = int.Parse(Console.ReadLine());
                Console.Write("Write the name: ");
                name = Console.ReadLine();
                Console.Write("Write the Salary: ");
                salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employee(id, name, salary));
                Console.WriteLine();



            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int idEmployee = int.Parse(Console.ReadLine());
           

            Employee emp = list.Find(x => x.Id == idEmployee);
            if(emp != null )
            {
                Console.Write("Enter the percentage");
                percentage = int.Parse(Console.ReadLine());
                emp.increaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Update list of employees");
            foreach(Employee obj in list)
            {
                Console.WriteLine(obj);
            }



        }
    }

}