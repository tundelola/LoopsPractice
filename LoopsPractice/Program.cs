using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            // Write a program in C# Sharp to display the first 10 natural numbers.
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);

            //}

            //Write a C# Sharp program to find the sum of first 10 natural numbers
            //int sum = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //   sum = sum + i;
            //    Console.Write("{0}",i);

            //}
            //Console.WriteLine("\nthe sum of the 10 natural numbers = {0}", sum);

            //Write a program in C# Sharp to display n terms of natural number and their sum.

            //int n = 7;
            //int sum = 0;

            //for (int i = 1; i <= n; i++)
            //{
            //    sum += i;
            //    Console.Write("{0}", i);
                
            //}
            //Console.WriteLine("\nThe sum of the n term natural number = {0}", sum);

            // Write a program in C# Sharp to read 10 numbers from keyboard and find their sum and average. 

            int sum = 0;
            int n;
            double aver;
           

            Console.WriteLine("Enter 10 numbers");
            for(int i =1; i<=10; i++)
            {
                //Console.Write("{0}", i);
                // n = Convert.ToInt32(Console.ReadLine());

                Console.Write("Number-{0} :", i);

                n = Convert.ToInt32(Console.ReadLine());
                sum +=n;
               

            }
           
            aver = sum / 10.0;
            Console.WriteLine("sum of the numbers = {0} \n aver of the numbers {1}", sum,  aver);

        }
    }
}
