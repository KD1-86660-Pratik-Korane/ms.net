﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1._2
{
    internal class Program
    {   

       static  int add(int x,int y) {return x + y; }
       static int sub(int x,int y)  {  return x - y;}
       static int mul(int x,int y) { return x * y; }

       static  int div(int x,int y) { return x/y; }

        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter operation to be performed");
              

            switch(Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("Enter first number and second number");
                    Console.WriteLine(add(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
                    break;
                case 2:
                    Console.WriteLine("Enter first number and second number");
                    Console.WriteLine(sub(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
                    break;
                case 3:
                    Console.WriteLine("Enter first number and second number");
                    Console.WriteLine(mul(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
                    break;
                case 4:
                    Console.WriteLine("Enter first number and second number");
                    Console.WriteLine(div(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
                    break;
                default: Console.WriteLine("Wrong operation selected...");
                    break;
            }
        }
    }
}
