﻿using System;
namespace parsingstr_int
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myString = "15";
            string mySecondString = "13";
            int num1 = Int32.Parse(myString);
            int num2 = Int32.Parse(mySecondString);
            int resultInt = num1 + num2;
            string result = myString + mySecondString;
            Console.WriteLine(num1.GetType().Name);
        }
    }
}
