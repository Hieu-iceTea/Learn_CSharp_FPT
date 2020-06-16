using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNet.CodeLean.Lab_03
{
    class Employee
    {
        private string firstName;
        private string lastName;
        private string address;
        private long sin;
        private double salary;

        public Employee(string firstName, string lastName, string address, long sin, double salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.sin = sin;
            this.salary = salary;
        }

        ~Employee()
        {
            Console.WriteLine("Destructor for Employee called");
        }

        public override string ToString()
        {
            return string.Format("Employee: {0} {1} {2} {3} {4}", firstName, lastName, address, sin, salary);
        }

        public double CalculateBonus(double percentage)
        {
            return this.salary * percentage;
        }
    }
}
