using interfacedemo;

internal class Program
{
    private static void Main(string[] args)
    {
        Company c = new Company();
        c.name = "ChangePond Technologies";
        c.addressline1 = "SIPCOT,Siruseri";
        c.city = "Chennai";
        c.state = "Tamil Nadu";
        c.postalcode = 600073;
        c.email = "contact@cp.com";
        c.mobilenum = 133334;
        c.addressdetails();
        c.contactdetails();

        Employee e = new Employee();
        e.name = "Senid ";
        e.addressline1 = "SIPCOT,Siruseri";
        e.city = "Chennai";
        e.state = "Tamil Nadu";
        e.postalcode = 60073;
        e.email = "contact@cp.com";
        e.mobilenum = 323900932;
        e.addressdetails();
        e.contactdetails();

    }
}
