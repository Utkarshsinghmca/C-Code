using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Ek number dalo check karne k liye kya wo even number hai ya phir odd number hai bhai");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.Write("Ye wala number even hai bhai");
                Console.Read();

            }
            else
            {
                Console.Write("Ye wala number odd hai bhai");
                Console.Read();
            }
        }
    }
}