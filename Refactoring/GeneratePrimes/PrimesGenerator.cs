using System;
/**
 * This class Generates primes numbers up to a user specified maximum.
 * The algorithm used is the Sieve of Eratosthenes.
 * <p>
 * Eratosthenes of Cirene, b. c. 276 BC, Cyrene, Libya --
 * d. c. 194, Alexandria. The first man to calculate the circumference of the Earth.
 * Also know for working on calendars with leap
 * <p>
 * The algorithm is quite simple. Given an array of integers starting at 2.
 * Cross out all multiples of 2. Find the next uncrossed integer, and cross out all of its multiples.
 * Repeat until you have passed the square root of the maximum value.
 * @author Robert C. Martin
 * @version 9 Dec 1999 rcm
 * **/
namespace Refactoring.GeneratePrimes
{
    public class PrimesGenerator
    {
        /*
         * @param maxValue i sthe generation limit.
        */
        public static int[] GeneratePrimes(int maxValue)
        {
            if (maxValue >= 2) // the only valid case
            {
                //declarations
                int s = maxValue + 1;//size of array
                bool[] f = new bool[s];
                int i;

                //initialize array to true
                for (i = 0; i < s; i++)
                    f[i] = true;

                //get rid of know non-primes
                f[0] = f[1] = false;

                //sieve
                int j;
                for ( i = 2; i < Math.Sqrt(s) + 1; i++)
                {
                    for (j = 2* i; j < s; j += i)
                       f[j] = false;// multiple is not prime
                }

                //how many primes are there?
                int count = 0;
                for (i = 0; i < s; i++)
                {
                    if (f[i])
                       count++; // bump count.
                }

                int[] primes = new int[count];

                //move the primes into the result.
                for (i = 0, j =0; i < s; i++)
                {
                    if (f[i])   //if prime
                        primes[j++] = i;
                }

                return primes; // return the prime
            }
            else // maxValue < 2
            {
                return new int[0]; // return null array if bad input.
            }
        }
    }
}
