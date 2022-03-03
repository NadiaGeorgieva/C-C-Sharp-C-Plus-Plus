using System;

namespace program03
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int size = 3;
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());

            }
            for (int j = 0; j < array.Length; j++)
            {
                Console.Write("["+j+"]"+"->"+array[j]+" ");
            }
        }
    }
}
