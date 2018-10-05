using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kitne (elements) numbers hai wo dalo :");


            string el = Console.ReadLine();


            int num = Int32.Parse(el);


            int[] array = new int[num];


            Console.WriteLine("numbers dalo sort karne k liye");

            for (int i = 0; i < num; i++)
            {

                string el1 = Console.ReadLine();

                array[i] = Int32.Parse(el1);
            }
                Array.Sort(array);

                Console.WriteLine("chote se bade order mai numbers hai :");

                for (int i = 0; i < num; i++)
                {
                Console.WriteLine("{0}", array[i]);

                }

            Console.Read();


            }


        }
    }

