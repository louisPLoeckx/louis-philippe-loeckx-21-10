using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Question_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int age = 5;
            double weigth = 72.5D;
             
            string firstName = "Louis";
            string lastName = "Loeckx";
            char middleharacter = 'P';

            Console.WriteLine($"Congratulations on turning {age} {firstName} {middleharacter}. {lastName}. You weigh {weigth}");
        }
    }
}
