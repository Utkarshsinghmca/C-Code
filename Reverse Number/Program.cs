using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kitne digit ka number hai wo dalo : ");
            string dg = Console.ReadLine();  //dg ka matlab digit

            int num = Int32.Parse(dg); //num ka matlab number

            int[] array = new int[num];

            Console.WriteLine("Apna number dalo ahb : ");
            for(int i = 0; i < num; i++)
            {
                string dg1 = Console.ReadLine(); 
                array[i] = Int32.Parse(dg1);

            }

            Array.Reverse(array);
            Console.WriteLine("Ulta number hai :");

            for(int i=0;i<num;i++)
            {
                Console.WriteLine("elements {0} is {1}", i + 1, array[i]);
            }
            Console.Read();

        }
    }
}
