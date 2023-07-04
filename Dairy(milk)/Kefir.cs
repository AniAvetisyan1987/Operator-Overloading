using System.Security.Cryptography.X509Certificates;

namespace Dairy_milk_
{
    internal class Kefir : Milk
    {
        public Kefir() {
            
        }
        public override void VirtualMethod()
        {
           
            Console.WriteLine("CHILD KEFIR VirtualMethod");
        }
    }
}
