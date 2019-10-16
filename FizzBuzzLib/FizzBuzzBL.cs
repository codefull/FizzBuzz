using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzLib
{
    /// <summary>
    /// Bussiness Logic class that expose functionalities that determines if a number  Fizz, Buzz or both
    /// </summary>
    public class FizzBuzzBL
    {
        /// <summary>
        /// Determines if a number is Fizz, Divisible by 3
        /// </summary>
        /// <param name="n"> A natural number </param>
        /// <returns>Boolean Value, true if the number is divisible</returns>
        public bool isFizz(int n)
        {
            return (n % 3 == 0);
        }

        /// <summary>
        /// Determines if a number is Buzz, Divisible by 5
        /// </summary>
        /// <param name="n"> A natural number </param>
        /// <returns>Boolean Value, true if the number is divisible</returns>
        public bool isBuzz(int n)
        {
            return (n % 5 == 0);
        }

        /// <summary>
        /// Determines if a number isn't Fizz and Buzz at the same time
        /// </summary>
        /// <param name="n"> A natural number </param>
        /// <returns>Boolean Value, true if the number isn't divisible by 3 and 5 at the same time</returns>
        public bool isNotFB(int n)
        {
            return ( (n % 3 != 0) && (n % 5 != 0) );
        }

        /// <summary>
        /// Determines if a number is Fizz and Buzz at the same time
        /// </summary>
        /// <param name="n"> A natural number </param>
        /// <returns>Boolean Value, true if the number is divisible by 3 and 5 at the same time</returns>
        public bool isFizzBuzz(int n)
        {
            return ((n % 3 == 0) && (n % 5 == 0));
        }
    }
}