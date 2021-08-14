using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine("Enter the Statement:");

         string statement = Console.ReadLine();
         string[] str = statement.Split(' ');
         int i = str.Length - 1;

         Console.WriteLine("Reversed statement is:");

         foreach (var element in str)
                while(i>=0)
                {
                    Console.Write($"{str[i]}{' '}");
                    i--;
                }

         Console.ReadLine();
        }
    }
}
