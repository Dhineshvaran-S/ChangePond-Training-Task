using productdemo;
class Program { 
public static void Main(String[] args)
{
    Shop shop = new Shop();
    shop.shopName = "MOBILE ARENA";
    shop.product_name = "I-PHONE";
    shop.product_price = 1000000;
    shop.product_category = "MOBILE PROD";
    shop.outlet_name = "INDIAN BRANCH";
    shop.outlet_city = "CHICKAGO";
    shop.outlet_location = "DENMARK";

    Console.WriteLine(shop.getProductDetails());
    Console.WriteLine(shop.getOutletDetails());
}

}