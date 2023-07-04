using PolymorphismHomework;

internal class Program
{
    private static void Main(string[] args)
    {
        for (int i = 0; i < 2000; i++)
        {
            //for int
            ChildClass intChild = new ChildClass();
            Console.WriteLine(intChild.MyMethod(12));

            //for float
            ChildClass floatChild = new ChildClass();
            Console.WriteLine(floatChild.MyMethod(12.4f,13.4f));

            ParentClass parent = new ParentClass();
            parent.MyParentMethod();

            ChildClass2 child = new ChildClass2();
            child.MyParentMethod();
            Console.WriteLine(i);
        }
        Console.ReadKey();
    }
}