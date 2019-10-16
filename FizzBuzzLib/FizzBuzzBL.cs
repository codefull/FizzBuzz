using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzLib
{
    public class FizzBuzzBL
    {
        public bool isFizz(int n)
        {
            return (n % 3 == 0);
        }

        public bool isBuzz(int n)
        {
            return (n % 5 == 0);
        }

        public bool isNotFB(int n)
        {
            return ( (n % 3 != 0) && (n % 5 != 0) );
        }

        public bool isFizzBuzz(int n)
        {
            return ((n % 3 == 0) && (n % 5 == 0));
        }
    }
}