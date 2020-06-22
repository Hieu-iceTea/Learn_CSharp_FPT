using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNet.CodeLean.AP_10_11
{
    abstract class Employee
    {
        private static int employeeCount = 1;

        #region 3 private member variables
        private string employeeName;
        private double employeeBaseSalary;
        private int employeeID;
        #endregion

        #region Public properties
        public string Name
        {
            get
            {
                return employeeName;
            } 
            set
            {
                employeeName = value;
            }
        }
        public double BaseSalary
        {
            get
            {
                return employeeBaseSalary;
            }
            set
            {
                employeeBaseSalary = value;
            }
        }
        public int ID
        {
            get
            {
                return employeeID;
            }
            set
            {
                employeeID = value;
            }
        }
        #endregion

        public Employee(string name, double baseSalary)
        {
            this.Name = name;
            this.BaseSalary = baseSalary;
            this.ID = employeeCount++;
        }

        #region Getter
        public double getBaseSalary()
        {
            return this.BaseSalary;
        }

        public string getName()
        {
            return this.Name;
        }

        public int getEmployeeID()
        {
            return this.ID;
        }
        #endregion

        public override string ToString()
        {
            return this.ID + " " + this.Name;
        }

        public abstract string empoloyeeStatus();

    }
}
