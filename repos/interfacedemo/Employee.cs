using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacedemo
{
    internal class Employee : Iaddress, Icontact
    {
        public string addressline1 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int postalcode { get; set; }
        public string email { get; set; }
        public int mobilenum { get; set; }

        public string name { get; set; }

        public void addressdetails()
        {
            Console.WriteLine("EmployeeS name : " + this.name);
            Console.WriteLine("Address Line 1: " + this.addressline1 + "\n" + "City: " + this.city + "\n" + "State: " + this.state + "\n" + "PostCode: " + this.postalcode);
        }

        public void contactdetails()
        {
            Console.WriteLine("Email: " + this.email + "\n" + "Mobile Number:" + this.mobilenum); ;
        }
    }
}