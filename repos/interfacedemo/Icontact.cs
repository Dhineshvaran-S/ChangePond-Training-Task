using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacedemo
{
    internal interface Icontact
    {


        string email { get; set; }



        int mobilenum { get; set; }

        void contactdetails();

    }
}