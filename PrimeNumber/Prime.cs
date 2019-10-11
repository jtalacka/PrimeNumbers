using System;

namespace PrimeNumber
{
    public class Prime
    {
        private int range1, range2;
        public Prime() { }


        public void setRange(int r1, int r2)
        {
            this.range1 = r1;
            this.range2 = r2;
        }
        public void iterateRange()
        {
            int r1 = range1;
            int r2 = range2;
            while (r1 <= r2)// iterating through the range of range1 and range2
            {
                checkPrime(r1);
                r1++;

            }
        }
        private void checkPrime(int r1)
        {
            if (r1 <= 0)// checking if number is positive and not 0
            {
                return;
            }
            bool prime = true;
            for (int i = 2; i < r1; i++)
            {
                if (r1 % i == 0)
                {
                    prime = false;
                    break;
                }
            }
            if (prime == true)
            {
                printPrime(r1);
            }


        }
        private void printPrime(int prime)
        {
            Console.Write(prime + " ");

        }

    }
}
