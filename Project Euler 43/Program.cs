using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Runtime.ExceptionServices;

namespace Project_Euler_43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Pandigital(1023456789));
            List<BigInteger> PandigitalNumbers = new List<BigInteger>();
            for (BigInteger i = 1000000000; i <= 9999999999; i++)
            {
                if (Pandigital(i) == true)
                {
                    PandigitalNumbers.Add(i);
                    //Console.WriteLine(i);
                }
            }
        }
        static bool Pandigital(BigInteger number)
        {
            for (int i = 0; i < 10; i++)
            {
                if (number.ToString().Contains(i.ToString()) == false)
                {
                    //Console.WriteLine(i.ToString());
                    return false;
                }
            }
            return true;
        }
        static bool CheckingDivisibility (BigInteger number)
            {
                int[] Primes = { 2, 3, 5, 7, 11, 13, 17 };
            int Substring = 0;
            int counter = 2;
            for (int i = 0; i < Primes.Length; i++)
            {

                    Substring = int.Parse(Primes[counter].ToString().Substring(j, 3));
                
                if (Substring % Primes[i] != 0)
                {
                    return false;
                }
            }
            return true;
            }
    }
}
