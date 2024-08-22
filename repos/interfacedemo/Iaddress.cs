using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacedemo
{
    internal interface Iaddress
    {

        string addressline1 { get; set; }
        string city { get; set; }

        string state { get; set; }
   
        int postalcode { get; set; }

        void addressdetails();

    }
}
