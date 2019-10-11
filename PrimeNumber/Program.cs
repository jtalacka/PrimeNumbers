using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Prime prime = new Prime();
            input(prime);
            prime.iterateRange();
            Console.ReadKey();

        }
        public static void input(Prime prime)
        {
            string range;
            Console.WriteLine("Please write two numbers");
            range = Console.ReadLine();
            string[] values = range.Split(' ');
            try {

                if (values.Length == 2)// checking if there'es more than two numbers
                {
                    int r1, r2;
                    r1 = Int32.Parse(values[0]);
                    r2 = Int32.Parse(values[1]);
                    if (r1<r2)
                    {
                        prime.setRange(r1,r2);
                    }
                    else
                    {
                        prime.setRange(r2,r1);
                    }

                    return;
                }
                else
                {
                    Console.WriteLine("Incorrect input, please try again");
                    input(prime);
                }


            }
            catch(Exception ex)// this opens up when there's symbols involved
            {
            
                Console.WriteLine("Incorrect input, please try again");
                input(prime);
            }
        }
    }
}
