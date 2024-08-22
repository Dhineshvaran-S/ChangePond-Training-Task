//namespace oopsdemo;

// class Program
//{
//    private static void Main(string[] args)
//    {
//        Student s1, s2;
//        s1=new Student();

//        s2=new Student();

//        s1.student_id = 1;
//        s1.student_name = "hARRY pOTTER";
//        s1.marks = 80;

//        s2.student_id = 2;
//        s2.student_name = "hARRY hER";
//        s2.marks = 90;

//        Student.collegename = "SAIRAM";

//        Console.WriteLine("Collg Name : " + Student.collegename);
//        Console.WriteLine("student ID : " + s1.student_id); 
//        Console.WriteLine("student Name : " + s1.student_name);
//        Console.WriteLine("student Marks : " + s1.marks);



//        Console.WriteLine("Collg Name : " + Student.collegename);
//        Console.WriteLine("student ID : " + s2.student_id);
//        Console.WriteLine("student Name : " + s2.student_name);
//        Console.WriteLine("student Marks : " + s2.marks);


//        Console.WriteLine("Hello, World!");


//        Employee e1, e2;
//        e1 = new Employee();
//        e2 = new Employee();

//        e1.emp_name = "Harry";
//        e1.emp_age = 22;
//        e1.salary = 78000;

//        e2.emp_name = "Harry Potter";
//        e2.emp_age = 22;
//        e2.salary = 75000;

//        Employee.company = "TCS";

//        Console.WriteLine("Company Name :" + Employee.company);
//        Console.WriteLine("EMP Name :" +e1.emp_name );
//        Console.WriteLine("EMP AGE :" + e1.emp_age);
//        Console.WriteLine("EMP SAL:" + e1.salary);



//        Console.WriteLine("Company Name :" + Employee.company);
//        Console.WriteLine("EMP Name :" + e2.emp_name);
//        Console.WriteLine("EMP Age:" + e2.emp_age);
//        Console.WriteLine("EMp SAL:" + e2.salary);

//    }
//}


using oopsdemo;

class Program
{
    private static void Main(string[] args)


    {


        //User u1, u2, u3, u4;

        ////for (int i = 0; i < 3; i++)
        ////{
        //Console.Write("enter username : ");
        //string username = Console.ReadLine();
        //Console.Write("Enter password : ");
        //string password = Console.ReadLine();
        //u1 = new User(username, password);
        //string result = u1.CheckLogin();
        //u1.getDetails();
        //Console.WriteLine(result);

        //u2 = new User("raayan", "mari", "guest user");

        //u2.getDetails();
        //result = u2.CheckLogin();
        //Console.WriteLine(result);

        //u3 = new User("harry", "potter", "guest user", "chennai");

        //u3.getDetails();
        //result = u3.CheckLogin();
        //Console.WriteLine(result);

        //u4 = new User("siva", "karthi", "new user", "chennai", false);

        //u4.getDetails();
        //result = u4.CheckLogin();
        //Console.WriteLine(result);



        //User u1;

        //for (int i = 0; i < 3; i++)
        //{
        //    Console.Write("enter username : ");
        //    string username = Console.ReadLine();
        //    Console.Write("Enter password : ");
        //    string password = Console.ReadLine();
        //    u1 = new User(username, password);
        //    string result = u1.CheckLogin();
        //    Console.WriteLine(result);
        //}


        //Console.WriteLine("Enter Number one :");
        //int num1 = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("Enter Number Two :");

        //int num2 = Convert.ToInt32(Console.ReadLine());

        //Calcical ma = new Calcical(num1, num2);
        //ma.display();




        Student s1, s2;
        s1 = new Student()
        {
            studentId = 1,
            studentname = "[Mary]",
            marks = 100
        };
        s2 = new Student()
        {
            studentId = 2,
            studentname = "[Soori]",
            marks = 90
        };


        Console.WriteLine("Collage name : " + " " + Student.collagename);
        Console.WriteLine("Student Id : " + " " + s1.studentId);
        Console.WriteLine("Student Name : " + " " + s1.studentname);
        Console.WriteLine("Student Marks : " + " " + s1.marks);
        Console.WriteLine();
        Console.WriteLine("Student Id : " + " " + s2.studentId);
        Console.WriteLine("Student Name : " + " " + s2.studentname);
        Console.WriteLine("Student Marks : " + " " + s2.marks);

    }

}

