using System;

namespace program04
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int size = 3;
            string[] array = new string[size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Console.ReadLine();
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("["+i+"]"+"->"+array[i]);
            }
        }
    }
}
