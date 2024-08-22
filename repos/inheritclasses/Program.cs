using inheritclasses;
using Task;

internal class Program
{
    private static void Main(string[] args)
    {


        BMW c = new BMW();
        c.brand = "BMW";
        c.model = "5-series";
        c.specialfeatures = "massage status";
        Console.WriteLine(c.getdetails());


        Merchant m = new Merchant();
        m.brand = "Merschant";
        m.model = "7_series";
        m.milage = "400km speed/hr";
        Console.WriteLine(m.getdetails());



        //Console.WriteLine("INHERITANCE CONCEPT !!!");

        //Person p = new Person("Good","Bad","male");
        ////p.firstName = "Shiva";
        ////p.lastName = "Lingam";
        ////p.gender = "Male";

        //Console.WriteLine("\n");
        //Console.WriteLine("Person Details :");
        //Console.WriteLine("\n");
        //Console.WriteLine("Person Full Name : " + p.firstName + " " + p.lastName);
        //Console.WriteLine("Person Gender : " + p.gender);
        //Console.WriteLine("\n");

        //Student s = new Student("Senid","Thug","male",1,100);
        ////s.studentId = 1;
        ////s.firstName = "Eashwar";
        ////s.lastName = "A";
        ////s.marks = 100;
        ////s.gender = "Male";

        //Console.WriteLine("\n");
        //Console.WriteLine("Student Details :");
        //Console.WriteLine("\n");
        //Console.WriteLine("Student Id : " + s.studentId);
        //Console.WriteLine("Student Full Name : " + s.firstName + " " + s.lastName);
        //Console.WriteLine("Student Mark : " + s.marks);
        //Console.WriteLine("Student Gender : " + s.gender);
        //Console.WriteLine("\n");

        //Employee e = new Employee("harry","Potter","male",9751,100000000);
        ////e.empId = 100;
        ////e.firstName = "Eashwar";
        ////e.lastName = "A";

        ////e.gender = "Male";
        ////e.salary = 8786798;

        //Console.WriteLine("\n");
        //Console.WriteLine("Employee Details :");
        //Console.WriteLine("\n");
        //Console.WriteLine("Employee Id : " + e.empId);
        //Console.WriteLine("Employee Full Name : " + e.firstName + " " + e.lastName);

        //Console.WriteLine("Employee Gender : " + e.gender);
        //Console.WriteLine("Employee Salary : " + e.salary);
        //Console.WriteLine("\n");



    }
}