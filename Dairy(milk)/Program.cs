using Dairy_milk_;

internal class Program
{
    private static void Main(string[] args)
    {
        //Milk milk = new Milk();
        //milk.MilkMethodWithParam("MILK");

        //Cheese cheese = new Cheese();
        //cheese.MilkMethodWithParam("CHESSE");
        //cheese.VirtualMethod();

        //SourCream sourCream = new SourCream();
        //sourCream.MilkMethodWithParam("SOURE CREAM");

        //Kefir kefir = new Kefir();
        //kefir.MilkMethodWithParam("KEFIR");
        //kefir.VirtualMethod();
        Milk kefir1 = new Kefir();
        kefir1.VirtualMethod();



        Console.ReadKey();  
    }
}