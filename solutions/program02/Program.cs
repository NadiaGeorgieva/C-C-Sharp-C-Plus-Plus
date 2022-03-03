using System;

namespace program02
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter number:");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter text:");
            string text = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("number:"+number);
            Console.WriteLine("text:"+text);
        }
    }
}
