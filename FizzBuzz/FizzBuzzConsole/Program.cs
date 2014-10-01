using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FizzBuzzConsole
{
    public  class Program
    {
        static void Main(string[] args)
        {

        }

        [TestCase (15, "FizzBuzz")]
        public void Translate (int input, string expected)
        {
            string result = FindFizzBuzz(input);
            Assert.That(result, Is.EqualTo(expected));

        }

        public string FindFizzBuzz(int vl)
        {
            var rtrn = "";
            if (vl % 3 == 0 && vl % 5 == 0) return "FizzBuzz";
            else if (vl % 3 == 0) return "Fizz";
            else if (vl % 5 == 0) return "Buzz";
            return rtrn;
        }

       
    }
}
