using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Question_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int one, two, three, four;
            one = 8;
            two = 6;
            three = 9;
            four = 4;

            int average = (one + two + three + four) / 4;
            double doubleAverage = 27D / 4D;
            string grade = (doubleAverage * 10) + "%.";

            Console.WriteLine("The Average of these four numbers is: " + average);
            Console.WriteLine("You got a {0} in your class", grade);

            
            
        }
    }
}
