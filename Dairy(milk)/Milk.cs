namespace Dairy_milk_
{
    internal class Milk
    {
        public Milk() {
            Console.WriteLine("Milk class");
        }
        private void MilkMethod(string milk)
        {
            Console.WriteLine("This is private parent method  ----" + milk);
        }

        public void MilkMethodWithParam(string milk)
        {
            Console.WriteLine("This is public parent method  ----" + milk);
            MilkMethod(milk);
        }

        public virtual void VirtualMethod()
        {
            Console.WriteLine("Parent Virtual method");
        }
    }
}
