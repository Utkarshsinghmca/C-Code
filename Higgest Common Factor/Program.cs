using System;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, i;
            int hcf = 0;
            Console.Write("Phela number lihkde bhai : ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Dusra number lhkde bhai : ");
            num2 = int.Parse(Console.ReadLine());
            for(i=1;i<=num1 || i<=num2;i++)
            {

                if(num1%i == 0 && num2%i == 0)
                {
                    hcf = i;
                }
            }
            Console.Write("Higgest Common Factor upar wale dono number ka hai ye : ");
            Console.WriteLine(hcf);
            Console.Read();

        }
    }
}
