using ConsoleApp3;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] arr1 = { 1, 2, 3, 4 };
        int[] arr2 = { 2, 3, 4, 5, 4};

        Box box1 = new Box(arr1);
        box1.SetLength(arr1.Length);
        

        Box box2 = new Box(arr2);
        box2.SetLength(arr2.Length);

        Box box3 = new Box();
        box3 = box1 + box2;
        box3.ShowArray();
        Console.ReadKey();

    }
}