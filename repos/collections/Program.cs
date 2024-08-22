
//class Program
//{
//    private static void Main(string[] args)
//    {
//        List<string> products = new List<string>() { "Butter", "Bread", "Milk", "Cheese" };
//        //Console.WriteLine(products[0]);
//        //foreach (string product in products)
//        //{
//        //    Console.WriteLine(product);
//        //}

//        string flag = "Y";
//        string item = "";
//        while (flag == "Y" || flag == "y")
//        {
//            Console.Write("Enter the Product to Add : ");
//             item = Console.ReadLine();
//            products.Add(item);
//            Console.Write("Want to add more product press Y: ");
//            flag = Console.ReadLine();

//        }
//        Console.Write("Enter the Product to Add at the start : ");
//        item = Console.ReadLine(); 
//        products.Insert(0, item);
//        Console.WriteLine("Products List");
//        foreach (string product in products)
//        {
//            Console.WriteLine(product);
//        }

//        List<string> fruits = new List<string> { "Apple", "Kiwi", "Banana" };
//        Console.WriteLine("Do you want to clear the list before adding the fruit list");
//        flag = Console.ReadLine();
//        if (flag == "Y" || flag == "y")
//        {
//            products.Clear();
//        }
//        products.AddRange(fruits);
//        Console.WriteLine("Products List and Fruit List");
//        foreach (string product in products)
//        {
//            Console.WriteLine(product);
//        }
//        Console.Write("Which item to Remove: ");
//        item = Console.ReadLine();
//        products.Remove(item);

//        Console.WriteLine("List after removing the item: " + item);
//        foreach (string product in products)
//        {
//            Console.WriteLine(product);
//        }
//        Console.Write("Which position item to be removed: ");
//        int pos = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("List after removing the item at position : " + pos);
//        products.RemoveAt(pos);
//        foreach (string product in products)
//        {
//            Console.WriteLine(product);
//        }
//    }
//}
//using System;
//using System.Collections.Generic;

//using System;
//using System.Collections.Generic;

//class Program
//{
//    private static void Main(string[] args)
//    {

//        List<(string, int)> products = new List<(string, int)>
//        {
//            ("Cheese", 200),
//            ("Bread", 40)
//        };

//        string flag = "Y";
//        string item;
//        int price;


//        while (flag == "Y" || flag == "y")
//        {
//            Console.Write("Add product from the menu: ");
//            item = Console.ReadLine();
//            Console.Write("Enter price of the product: ");
//            price = Convert.ToInt32(Console.ReadLine());
//            products.Add((item, price));
//            Console.Write("Do you want to continue (Y/N): ");
//            flag = Console.ReadLine();
//        }


//        int choice;
//        do
//        {
//            Console.WriteLine("What do you want to do next?");
//            Console.WriteLine("1. Update");
//            Console.WriteLine("2. Remove");
//            Console.WriteLine("3. Show the list");
//            Console.Write("Choose an option: ");
//            choice = Convert.ToInt32(Console.ReadLine());

//            if (choice == 1)
//            { 
//                Console.Write("Enter item to be op: ");
//                string oldItem = Console.ReadLine();
//                Console.Write("Enter new item name: ");
//                string newItem = Console.ReadLine();
//                Console.Write("Enter new price: ");
//                int newPrice = Convert.ToInt32(Console.ReadLine());

//                bool op = false;
//                for (int i = 0; i < products.Count; i++)
//                {
//                    if (products[i].Item1.Equals(oldItem))
//                    {
//                        products[i] = (newItem, newPrice);
//                        op = true;
//                        break;
//                    }
//                }
//                if (op)
//                {
//                    Console.WriteLine($"op {oldItem} to {newItem} with price {newPrice}.");
//                }
//                else
//                {
//                    Console.WriteLine($"{oldItem} not found.");
//                }
//                break;
//            }
//            if (choice == 2)
//            {  
//                Console.Write("Enter item to be removed: ");
//                string itemToRemove = Console.ReadLine();

//                bool removed = false;
//                for (int i = 0; i < products.Count; i++)
//                {
//                    if (products[i].Item1.Equals(itemToRemove))
//                    {
//                        products.RemoveAt(i);
//                        removed = true;
//                        break;
//                    }
//                }
//                if (removed)
//                {
//                    Console.WriteLine($"{itemToRemove} removed from the list.");
//                }
//                else
//                {
//                    Console.WriteLine($"{itemToRemove} not found.");
//                }
//                break;
//            }

//            if (choice == 3) {  
//                Console.WriteLine("List of items:");
//                for (int i = 0; i < products.Count; i++)
//                {
//                    Console.WriteLine($"{i + 1}. {products[i].Item1} {products[i].Item2}");
//                }
//                break;
//            }
//            else { 
//                    Console.WriteLine("Invalid option.");
//                    break;
//            }


//        } while (choice != 3);
//    }
//}



//List<int> ints = new List<int> { 10, 15, 32, 49, 25, 33, 22, 66, 89 };
//List<int> evenlist = new List<int>();

//evenlist = (from items in ints where (items % 2 == 0) select items).ToList();

//foreach (int i in evenlist)
//    Console.WriteLine(i);

//List<string> products = new List<string>() { "Butter", "Bread", "Milk", "Cheese" };
//List<string> op = new List<string>();
//Console.WriteLine("Enter to check :");
//string ip = Console.ReadLine();
//op= (from pro in products where (pro == ip) select pro).ToList();
//foreach (string i in op)
//{
//    Console.WriteLine(i + "input is Available in Products");

//}
using System.Runtime.InteropServices;

namespace collections;
class Program
{
    private static void Main(string[] args)
    {


        //    Prod p1, p2, p3;
        //    p1 = new Prod()
        //    {
        //        Id = 1,
        //        Name = "Shirts",
        //        Price = 250
        //    };
        //    p2 = new Prod()
        //    {
        //        Id = 1,
        //        Name = "T-Shirts",
        //        Price = 301
        //    };
        //    p3 = new Prod()
        //    {
        //        Id = 1,
        //        Name = "V-Neck T-Shirts",
        //        Price = 310
        //    };
        //    List<Prod> Prods = new List<Prod>() { p1, p2, p3 };
        //    List<Prod> cartList = new List<Prod>();

        //    for (int i = 0; i < Prods.Count; i++)
        //    {
        //        Prod Prod = Prods[i];
        //        if (Prod.Price > 300)
        //        {
        //            cartList.Add(Prod);
        //        }
        //    }


        //    for (int i = 0; i < cartList.Count; i++)
        //    {
        //        Prod Prod = cartList[i];
        //        Console.WriteLine(Prod.Name + " " + Prod.Price);
        //        Console.WriteLine($"Id: {Prod.Id}, Name: {Prod.Name}, Price: {Prod.Price}");

        //    }



        Dictionary<int, string> empdetails;

        empdetails = new Dictionary<int, string>();
    
        empdetails.Add(100, "Parag");
    
        empdetails.Add(102, "Prachi");

        empdetails.Add(103, "Manas");
 
        string ename = empdetails[102];

        Console.WriteLine(ename);
     
        SortedList<string, int> Marks;

        Marks = new SortedList<string, int>();  

        Marks.Add("Maths", 80);
    
        Marks.Add("Physics", 90);

        Marks.Add("English", 65);

        Marks.Add("Chemistry", 75);
 
        foreach(string key in Marks.Keys )

        {

        Console.WriteLine(Marks[key]);

        }
 

        }
    }


