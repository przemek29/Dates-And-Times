﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime myValue = DateTime.Now;
            //Console.WriteLine(myValue.ToString());
            //Console.WriteLine(myValue.ToShortDateString());
            //Console.WriteLine(myValue.ToShortTimeString());
            //Console.WriteLine(myValue.AddDays(3).ToShortDateString());
            //Console.WriteLine(myValue.AddHours(-3).ToShortTimeString());
            //Console.WriteLine(myValue.Month.ToString());

            //DateTime myBirthDate = new DateTime(1991, 10, 29);
            DateTime myBirthDate = DateTime.Parse("06/29/1990");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthDate);

            Console.WriteLine(myAge.TotalDays.ToString());
            Console.ReadLine();


        }
    }
}
