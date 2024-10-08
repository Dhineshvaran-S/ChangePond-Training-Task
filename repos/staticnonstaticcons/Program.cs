﻿enum PaymentOptions
{
    CreditCard, DebitCard, NetBanking, Wallet
}
class Payment
{
    public string invoicename { get; set; }
    public PaymentOptions options;
    public static int noofpayments, paymentoptionscountC;
    static Payment()
    {
        noofpayments = 0;
        paymentoptionscountC = 0;
    }
    public Payment()
    {
        noofpayments += 1;
    }
    public void getPayementOptionWiseCount()
    {
        if (this.options == PaymentOptions.CreditCard)
        {
            paymentoptionscountC += 1;
        }
    }
    public override string ToString()
    {
        System.Console.WriteLine(base.GetHashCode());
        return "Class1.ToString";
    }
}
class Program
{
    private static void Main(string[] args)
    {
        Payment p = new Payment();
        p.invoicename = "BroadBandBill";
        p.options = PaymentOptions.CreditCard;
        p.getPayementOptionWiseCount();
        Console.WriteLine(p.invoicename + " is paid by " + p.options);
        Payment p1 = new Payment();
        p1.invoicename = "AmazonShopping";
        p1.options = PaymentOptions.CreditCard;
        p1.getPayementOptionWiseCount();
        Console.WriteLine(p1.invoicename + " is paid by " + p1.options);
        Payment p2 = new Payment();
        p2.invoicename = "AmazonShopping - 1";
        p2.options = PaymentOptions.NetBanking;
        p2.getPayementOptionWiseCount();
        Console.WriteLine(p1.invoicename + " is paid by " + p2.options);
        Console.WriteLine("No of Payment recieved: " + Payment.noofpayments);
        Console.WriteLine("No of times Credit Card Used: " + Payment.paymentoptionscountC);
    
    
    }
}

//Generic code

//class Program
//{
//    class Profile<T1, T2>
//    {
//        public T1 Gender;
//        public T2 isAdult;
//    }
//    private static void Main(string[] args)

//    {

//        Profile<string, bool> profile;
//        profile = new Profile<string, bool>();
//        profile.Gender = "Male";
//        profile.isAdult = true;
//        Console.WriteLine("Gender: " + profile.Gender);
//        Console.WriteLine("Is Adult: " + profile.isAdult);
//        Profile<int, int> profile1;
//        profile1 = new Profile<int, int>();
//        profile1.Gender = 0;
//        profile1.isAdult = 0;
//        string gender = profile1.Gender == 1 ? "Female" : "Male";
//        Console.WriteLine("Gender: " + gender);
//        string isadult = profile1.isAdult == 0 ? "True" : "False";
//        Console.WriteLine("isAdult: " + isadult);

//    }
//}


