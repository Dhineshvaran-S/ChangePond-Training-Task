using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritclasses
{
    internal class Employee : Person
    {
        public int empId { get; set; }
        public double salary { get; set; }


        public Employee(string firstName, string lastName, string gender, int empId, int salary) : base(firstName, lastName, gender)
        {
            this.empId = empId;
            this.salary = salary;
        }


        //POLYMORPHISM
        public void displayDetails()
        {
            Console.WriteLine("Employee Id :" + this.empId);
            base.displayDetails();
            Console.WriteLine("Employee Salary : " + this.salary);
        }

    }
}
