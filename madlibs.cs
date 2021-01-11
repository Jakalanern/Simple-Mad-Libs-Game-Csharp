using System;

namespace Mad_Lib_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string color, pluralNoun, celebrity;

            Console.WriteLine("Name a color: ");            
            color = Console.ReadLine();

            Console.WriteLine("Write a plural noun: ");            
            pluralNoun = Console.ReadLine();

            Console.WriteLine("Write a celebrties name: ");           
            celebrity = Console.ReadLine();

            Console.WriteLine("\n");
            Console.WriteLine("Roses are " + color);
            Console.WriteLine("Violets are " + pluralNoun);
            Console.WriteLine("I love " + celebrity);
            Console.ReadLine();
        }
    }
}
