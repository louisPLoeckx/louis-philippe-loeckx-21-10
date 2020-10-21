using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Questions_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceCandyOne = 0.42;
            double priceCandyTwo = 1.02;
            double moneyToReturn;
            double moneyToReturnTwo;
            double rest = 1;

            //coins variables
            double twoEuro = 2;
            double oneEuro = 1;
            double fiftyCent = 0.50;
            double twentyCent = 0.20;
            double tenCent = 0.1;
            double fiveCent = 0.05;
            double twoCent = 0.02;
            double oneCent = 0.01;


            /*
            int returnTwo;
            int returnOne;
            int returnFiftyCent;
            int returntwentyCent;
            int returnTenCent;
            int returnFiveCent;
            int returnTwoCent;
            int returnOneCent;
            */
            Console.WriteLine($"The candy you are buying costs {priceCandyOne}");
            moneyToReturn = twoEuro-priceCandyOne;
            
            //Console.WriteLine(moneyToReturn);
            //Console.Write($"You recieve ");
            /*
            //returnTwo = Convert.ToInt32(moneyToReturn / o);
            //Console.WriteLine($"cw{returnTwo}");
            
            do
            {
                if (moneyToReturn >= twoEuro)
                {
                    returnTwo = Convert.ToInt32(twoEuro / moneyToReturn);
                    rest = moneyToReturn % twoEuro;
                    moneyToReturn = rest;
                    Console.WriteLine($"{twoEuro} euro: {returnTwo}");
                }
                else if (moneyToReturn >= oneEuro)
                {
                    returnOne = Convert.ToInt32((oneEuro / moneyToReturn));
                    rest = moneyToReturn % oneEuro;
                    moneyToReturn = rest;
                    Console.WriteLine($"{oneEuro} euro: {returnOne}");
                }
                else if (moneyToReturn >= fiftyCent)
                {
                    returnFiftyCent = Convert.ToInt32(fiftyCent / moneyToReturn);
                    rest = moneyToReturn % fiftyCent;
                    moneyToReturn = rest;
                    Console.WriteLine($"{fiftyCent} euro: {returnFiftyCent}");
                }
                else if (moneyToReturn >= twentyCent)
                {
                    returntwentyCent = Convert.ToInt32(twentyCent / moneyToReturn);
                    rest = moneyToReturn % twentyCent;
                    moneyToReturn = rest;
                    Console.WriteLine($"{twentyCent} euro: {returntwentyCent}");
                }
                else if (moneyToReturn >= tenCent)
                {
                    returnTenCent = Convert.ToInt32(tenCent / moneyToReturn);
                    rest = moneyToReturn % tenCent;
                    moneyToReturn = rest;
                    Console.WriteLine($"{tenCent} euro: {returnTenCent}");
                }
                else if (moneyToReturn >= fiveCent)
                {
                    returnFiveCent = Convert.ToInt32((fiveCent / moneyToReturn));
                    rest = moneyToReturn % fiveCent;
                    moneyToReturn = rest;
                    Console.WriteLine($"{fiveCent} euro: {returnFiveCent}");
                }
                else if (moneyToReturn >= twoCent)
                {
                    returnTwoCent = Convert.ToInt32((twoCent / moneyToReturn));
                    rest = moneyToReturn % twoCent;
                    moneyToReturn = rest;
                    Console.WriteLine($"{twoCent} euro: {returnTwoCent}");
                }
                else if (moneyToReturn >= oneCent)
                {
                    returnOneCent = Convert.ToInt32(oneCent / moneyToReturn);
                    rest = moneyToReturn % oneCent;
                    moneyToReturn = rest;
                    Console.WriteLine($"{oneCent} euro: {returnOneCent}");
                }
                else
                {
                    break;
                }
            } while (moneyToReturn != 0);
            */

            double[] coins = {twoEuro, oneEuro, fiftyCent, twentyCent, tenCent, fiveCent, twoCent, oneCent};

            foreach (double coin in coins)
	        {
                if (moneyToReturn >= coin)
                {
                    int returnOne = Convert.ToInt32(coin / moneyToReturn);
                    //Console.WriteLine(coin / moneyToReturn);
                    moneyToReturn = moneyToReturn % coin;
                    Console.WriteLine($"{coin} euro: {returnOne}");
                }
        	}

            Console.WriteLine($"The candy you are buying costs {priceCandyTwo}");
            moneyToReturnTwo = twoEuro -priceCandyTwo;

            foreach (double coin in coins)
	        {
                if (moneyToReturnTwo >= coin)
                {
                    int returnOne = Convert.ToInt32(coin / moneyToReturnTwo);
                    //Console.WriteLine(returnOne);
                    //Console.WriteLine(coin / moneyToReturnTwo);
                    moneyToReturnTwo = moneyToReturnTwo % coin;
                    //Console.WriteLine(moneyToReturnTwo);
                    Console.WriteLine($"{coin} euro: {returnOne}");
                }
        	}

            /*
            do
            {
                if (moneyToReturnTwo >= twoEuro)
                {
                    returnTwo = Convert.ToInt32(twoEuro / moneyToReturnTwo);
                    rest = moneyToReturnTwo % twoEuro;
                    moneyToReturnTwo = rest;
                    Console.WriteLine($"{twoEuro} euro: {returnTwo}");
                }
                else if (moneyToReturnTwo >= oneEuro)
                {
                    returnOne = Convert.ToInt32((oneEuro / moneyToReturnTwo));
                    rest = moneyToReturnTwo % oneEuro;
                    moneyToReturnTwo = rest;
                    Console.WriteLine($"{oneEuro} euro: {returnOne}");
                }
                else if (moneyToReturnTwo >= fiftyCent)
                {
                    returnFiftyCent = Convert.ToInt32(fiftyCent / moneyToReturnTwo);
                    rest = moneyToReturnTwo % fiftyCent;
                    moneyToReturnTwo = rest;
                    Console.WriteLine($"{fiftyCent} euro: {returnFiftyCent}");
                }
                else if (moneyToReturnTwo >= twentyCent)
                {
                    returntwentyCent = Convert.ToInt32(twentyCent / moneyToReturnTwo);
                    rest = moneyToReturnTwo % twentyCent;
                    moneyToReturnTwo = rest;
                    Console.WriteLine($"{twentyCent} euro: {returntwentyCent}");
                }
                else if (moneyToReturnTwo >= tenCent)
                {
                    returnTenCent = Convert.ToInt32(tenCent / moneyToReturnTwo);
                    rest = moneyToReturnTwo % tenCent;
                    moneyToReturnTwo = rest;
                    Console.WriteLine($"{tenCent} euro: {returnTenCent}");
                }
                else if (moneyToReturnTwo >= fiveCent)
                {
                    returnFiveCent = Convert.ToInt32((fiveCent / moneyToReturnTwo));
                    rest = moneyToReturnTwo % fiveCent;
                    moneyToReturnTwo = rest;
                    Console.WriteLine($"{fiveCent} euro: {returnFiveCent}");
                }
                else if (moneyToReturnTwo >= twoCent)
                {
                    returnTwoCent = Convert.ToInt32((twoCent / moneyToReturnTwo));
                    rest = moneyToReturnTwo % twoCent;
                    moneyToReturnTwo = rest;
                    Console.WriteLine($"{twoCent} euro: {returnTwoCent}");
                }
                else if (moneyToReturn >= oneCent)
                {
                    returnOneCent = Convert.ToInt32(oneCent / moneyToReturnTwo);
                    rest = moneyToReturnTwo % oneCent;
                    moneyToReturnTwo = rest;
                    Console.WriteLine($"{oneCent} euro: {returnOneCent}");
                }
                else
                {
                    break;
                }
            } while (moneyToReturnTwo != 0);
            */
            
            

        }
    }
}
