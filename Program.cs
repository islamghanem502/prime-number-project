using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, x = 0;
            Console.Write("enter n1: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("enter n2: ");
            n2 = int.Parse(Console.ReadLine());

            for(int i =n1; i<n2; i++)
            {
                for(int j = 1; j<n2; j++)
                {
                    if(i%j == 0)
                    {
                        x++;
                    }
                }

                if (x == 2)
                {
                    Console.WriteLine(i);
                }
                x = 0;

            }







        }
    }
}
