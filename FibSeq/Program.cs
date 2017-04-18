using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibSeq
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            do
            {

                Console.Write("Please enter a number: ");
                int input = Convert.ToInt32(Console.ReadLine());

                FibSeq(input);

                Console.Write("Cont?");
                string cont = Console.ReadLine();

                if (cont == "n")
                {
                    run = false;
                }

            }while (run == true);
        }

        public static void FibSeq(int input)
        {
            double x = 0;
            double z = 1;
            double f = 0;

            if (input >= 1 && input <= 2)
            {
                f = 1;
            }
            else
            {
                for  (int y=1; y<=input; y++)
                {
                    f = z + x;
                    x = z;
                    z = f;
                }
        }
        Console.WriteLine(f);
        }      
    }
}
