//Kala Rodriguez

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3, num4;
            num1 = 32.675;
            num2 = 50.001;
            num3 = 10.005;
            num4 = 2.10;

            double addResult = Add(num1, num2);
            double subResult = Subtract(num3, num4);

            Console.WriteLine($"{num1.ToString("N2")} + {num2.ToString("N2")} = {addResult.ToString("N2")}");
            Console.WriteLine($"{num3.ToString("N2")} - {num4.ToString("N2")} = {subResult.ToString("N2")}");

            double[] allTheNums = new double[5];
            allTheNums[0] = 1;
            allTheNums[1] = 4;
            allTheNums[2] = 5;
            allTheNums[3] = 10;
            allTheNums[4] = 20;

            addResult = Add(allTheNums);

            Console.WriteLine(addResult);
          

            Console.ReadKey();

        }

        static double Add(double value1, double value2)
        {
            var sum = value1 + value2;
            return sum;
        }

        static double Add(double[] values)
        {
            double sum = 0;

            //int counter = 0;


            //while (counter < values.Length)
            //{
            //    sum += values[counter];
            //    counter++;
            //}


            //for (counter = 0; counter < values.Length; counter++)
            //{
            //    sum += values[counter];
            //}


            foreach (var item in values)
            {
                sum += item;                
            }

            return sum; 
        }

        static double Subtract(double value1, double value2)
        {            
            return value1 - value2;
        }

        static void DatabaseStuff()
        {

        }
    }
}
