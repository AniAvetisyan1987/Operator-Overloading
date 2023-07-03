using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Box
    {
        private int[] arr;
        
        public int len;
        public Box() { }
        public Box(int[] x)
        {
            arr = x;
        }

        public void SetLength(int arrLength)
        {
            len = arrLength;
        }


        public void ShowArray()
        {

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public static Box operator +(Box b1, Box b2)
        {
            int maxLen = b1.len > b2.len ? b1.len : b2.len;
            Array.Resize<int>(ref b1.arr, maxLen);
            Array.Resize<int>(ref b2.arr, maxLen);
            if (b1.len > b2.len)
            {

            }
            Box box = new Box();
            box.arr = new int[maxLen];

            for (int i = 0; i < maxLen; i++)
            {
                box.arr[i] = b1.arr[i] + b2.arr[i];
            }
            return box;
        }
    }
}
