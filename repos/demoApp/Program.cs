



// Console.WriteLine("Hello, World!");
//ACCESS MODIFIERS IN .NET 
//class Student
//{
//    private int std_id;
//    protected int yob;
//    internal int age;
//    protected internal string gender;
//    public string fname;

//    public string getDetails()
//    {
//        std_id = 1;//Private members is accesible in the same class only.
//        yob = 2001;//protected members is accessible in the same class and child class.
//        age = 21;//Internal is accessible in same file but not other file .
//        gender = "male";
//        fname = "Harry";//public members is accessible in any class

//        return "ID:" + std_id + "YOB :" + yob + " AGE :" + age + " GENDER:" + gender + "FIRST_NAME :" + fname;
//    }
//}

//class School : Student
//{
//    public string schoolName;
//    public string getDetailsWithSchool()
//    {

//        yob = 1995;//protected members is accessible in the same class and child class.
//        age = 21;
//        gender = "male";
//        fname = "Harry";//public members is accessible in any class
//        schoolName = "Hogwarts";
//        return "YOB :" + yob + " AGE :" + age + " GENDER:" + gender + "FIRST_NAME :" + fname + "SCHOOL_NAME :" + schoolName;
//    }

//}
//class Parent
//{
//    public string getStudentDetails()
//    {
//        Student student = new Student();
//        student.fname = "harry";
//        student.age = 21;
//        student.gender = "Male";
//        return "STUDENT_FNAME :" + student.fname + "STUDENT_AGE :" + student.age + "STUDENT_GENDER :" + student.gender;
//    }
//}

//class Program
//{
//    private static void Main(string[] args)
//    {


//        Student student = new Student();
//        string d1 = student.getDetails();
//        Console.WriteLine(d1);
//        School school = new School();
//        string d2 = school.getDetailsWithSchool();
//        Console.WriteLine(d2);
//        Parent parent = new Parent();
//        string d3 = parent.getStudentDetails();
//        Console.WriteLine(d3);
//    }

//}




//class Program
//{
//    private static void Main(string[] args)
//    {
//Console.WriteLine("Hello");
//System.Console.ReadLine();
//System.Console.Clear();
//Console.WriteLine("Welcome to dotnet");
//System.Console.ReadLine();

//sbyte a = 10;
//byte b = 20;
//short s = 30;
//ushort d = 40;
//int e = 50;
//uint f = 70;
//long g = 55;
//ulong h = 60;
//float i = 90.23F;
//double j = 33d;
//decimal k = 110.23432432M;


//uint min = uint.MinValue;
//uint max = uint.MaxValue;

//Console.WriteLine(min);
//Console.WriteLine(max);
//Console.WriteLine(a);
//Console.WriteLine(b);
//Console.WriteLine(s);
//Console.WriteLine(d);
//Console.WriteLine(e);
//Console.WriteLine(f);
//Console.WriteLine(g);
//Console.WriteLine(h);
//Console.WriteLine(i);
//Console.WriteLine(j);
//Console.WriteLine(k);

//char ch = 'h';

//string str = "hiii all";
//Console.WriteLine(str);

//Console.WriteLine(ch);


// OPERATORS

//double num1 = 35; double num2 = 20;
//Console.WriteLine(num1 + num2);
//Console.WriteLine(num1 - num2);
//Console.WriteLine(num1 * num2);
//Console.WriteLine(num1 / num2);
//Console.WriteLine(num1 % num2);


//double num_1 = 35; double num_2 = 20;
//Console.WriteLine(num_1 += num_2);
//Console.WriteLine(num_1 -= num_2);
//Console.WriteLine(num_1 *= num_2);
//Console.WriteLine(num_1 /= num_2);
//Console.WriteLine(num_1 %= num_2);

//int x = 10, y = 20, z = 10;
//bool result1 = ((x==y) && (y==z));
//Console.WriteLine(result1);
//bool result2 = ((x == y) && (y > z));
//Console.WriteLine(result2);
//bool result3 = !result1;
//Console.WriteLine(result3);

//string str1 = "Good Morning ";
//string str2 = "Welcome to class ";
//Console.WriteLine(str1 + " " + str2);
//int num = 10;
//Console.WriteLine(str1+num);


//int num_1 = 13;
////string result = ((num_1%2==0)?"EVEN" : "ODD");
//if(num_1%2==0)
//{
//    Console.WriteLine(num_1 + " is evem");
//}
//else
//{
//    Console.WriteLine(num_1 + " is odd");
//}
////Console.WriteLine(result);


//int year = 1900;
//if ((year % 400 == 0) || (year % 4 == 0) && (year % 100 != 0))
//{
//    Console.WriteLine(year + " is a leap year");
//}
//else
//{
//    Console.WriteLine(year + " is not a leap year");
//}

//int marks = 99;
//if (marks >= 75)
//{
//    System.Console.WriteLine("Distinction");

//}
//else if(marks >=60 && marks < 75)
//{
//    System.Console.WriteLine("First Class");

//}
//else if(marks >=50 && marks <60)
//{
//    System.Console.WriteLine("Third Class ");

//}
//else
//{
//    System.Console.WriteLine("Fail");
//}


//int x = 7000, y = 8000, z = 400;

//if ((x > y) && (x > z))
//{
//    Console.WriteLine("x="+x + " is larger");
//}
//else if  (y > z)
//{
//    Console.WriteLine("y="+y + " is larger ");
//}
//else

//{
//    Console.WriteLine("z="+z + " is larger ");
//}


//string monthname = " ";
//int monthno = 120;
//switch (monthno)
//{
//    case 1: monthname = "january";break;
//    case 2: monthname = "February";break;
//    case 3: monthname = "March";break;
//    case 4: monthname = "April"; break;
//    case 5: monthname = "May"; break;
//    case 6: monthname = "June"; break;
//    case 7: monthname = "July"; break;
//    case 8: monthname = "August"; break;
//    case 9: monthname = "September"; break;
//    case 10: monthname = "October "; break;
//    case 11:monthname = "November";break;
//    case 12: monthname = "December"; break;
//    default: monthname = "WRONG ";break;



//}

//Console.WriteLine(monthname);

// int num = 7;
// int fact = 1;
//int  num_1 = num;
// while (num>1)
// {


//     fact *= num;
//     num--;
// }
// Console.WriteLine("factorial of " + num_1 + "is " + fact);


//int i = 1;
//int sumofodds = 0;
//do
//{
//    if (i % 2 == 1)
//    {
//        sumofodds += i;

//    }
//    i++;
//}
//while (i < 100);
//Console.WriteLine("Sum of odd numbers between 1 to 100 is " + sumofodds);


//int sumofnum = 0;
//for(int i = 0; i < 100; i++)
//{
//    if (i % 10 == 0)
//    {
//        sumofnum += i;

//    }
//}Console.WriteLine(sumofnum);
//int num1 = 6;
//int fact = 1; 


//for (int i=num1;i>1;i--)
//{
//    fact *= i;

//}
//Console.WriteLine(fact);



//int number = 64351;
//int sum=0;
//while (number > 0)
//{
//   sum+= number % 10;
//    number /= 10;

//}
//Console.WriteLine(sum);


//        int num1 = 17;
//        bool isPrime = num1 > 1;

//        for (int i = 2; i < num1; i++)
//        {
//            if (num1 % i == 0)
//            {
//                isPrime = false;
//                break;
//            }
//        }

//        if (isPrime)
//        {
//            Console.WriteLine(num1 + " is a prime number");
//        }
//        else
//        {
//            Console.WriteLine(num1 + " is not  a prime number");
//        }
//    }

//}