using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{

    //Inheritance is feature and behavior acquiring in derived class from base class.
    //There are three type of inheritance 
    //Single only one class is inherited 
    //Multilevel here derived class can inherit another class which have property of base class.
    //Hierachial inheritance base class can derived multiple derived class.
    class Employee
    {
        public Employee()
        {
            Console.WriteLine("Base constructor");
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public void Details()
        {
            Console.WriteLine($"Id:{Id} and Name:{Name}");
        }
    }

    class TemporaryEmployee : Employee
    {
        public TemporaryEmployee()
        {
            Console.WriteLine("Derived constructor");
        }
        public int TempId { get; set; }
        public virtual double CalculteSalary(double salary)
        {
           return salary = salary * 0.5;
        }
    }

    class PermanentEmployee : TemporaryEmployee
    {
        public override double CalculteSalary(double salary)
        {
            var result= salary * 2;
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TemporaryEmployee temporaryEmployee = new TemporaryEmployee();
            temporaryEmployee.Name = "Niraj shukla";
            temporaryEmployee.Salary = 1000;
            temporaryEmployee.TempId = 201;
            double Sal= temporaryEmployee.CalculteSalary(temporaryEmployee.Salary);
            Console.WriteLine($"Id{temporaryEmployee.TempId} NAME : {temporaryEmployee.Name} SALARY:{Sal}");
            Console.WriteLine("--------------------------------");
            PermanentEmployee permanent = new PermanentEmployee();
            double SalForPermenant=permanent.CalculteSalary(temporaryEmployee.Salary);
            Console.WriteLine($"Salary for permanent:{SalForPermenant}");
            Console.WriteLine("--------------------------------");
            Console.ReadLine();
        }
    }

}
