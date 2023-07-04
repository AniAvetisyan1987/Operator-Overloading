namespace Dairy_milk_
{
    internal class Cheese : Milk
    {
        public Cheese() {
            
        }
        public void MilkMethodWithParam(string milk)
        {
            Console.WriteLine("This is Cheese class ---- " + milk);
        }
    }
}
