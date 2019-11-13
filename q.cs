using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace JamQuestions
{
    //implement unique method, in a way that it takes two or more arrays, 
    //and returns a single array in unique manner in a comma separated string
    //cannot use any looping constructs like for, foreach
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
    //        string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };
    //        Console.WriteLine(string.Join(", ", UniqueNames(names1, names2))); // should print Ava, Emma, Olivia, Sophia
    //    }
    //    public static string[] UniqueNames(string[] names1, string[] names2)
    //    {
    //        return names1.Concat(names2).Distinct().ToArray();
    //    }
    //}



    //Reverse each word in a string
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        string input = "I am going to reverse myself.";
    //        Console.WriteLine(ReverseString(input));
    //    }
    //    public static string ReverseString(string input)
    //    {
    //        return String.Join(" ", input.Split(' ').Select(word => new String(word.Reverse().ToArray())));
    //    }
    //}

    //// find the angle between hour and minute hands of a clock at any given time
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int hours = 9;
    //        int minutes = 30;
    //        Console.WriteLine(FindAngleinTime(hours,minutes));
    //    }

    //    public static double FindAngleinTime(int hours, int mins)
    //    {
    //        double hourDegrees = (hours * 30) + (mins * 30.0 / 60);
    //        double minuteDegrees = mins * 6;
    //        double diff = Math.Abs(hourDegrees - minuteDegrees);
    //        if (diff > 180)
    //        {
    //            diff = 360 - diff;
    //        }
    //        return diff;
    //    }
    //}


    //Given an instance circle of the following class, write code to calculate the circumference of the circle, 
    //without modifying the Circle class itself
    //public sealed class Circle
    //{
    //    private double radius;

    //    public double Calculate(Func<double, double> op)
    //    {
    //        return op(radius);
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Circle circle = new Circle();
    //        Console.WriteLine(circle.Calculate(r => 2 * Math.PI * r));

    //        //solution 2
    //        var radius = circle.Calculate(r => r);
    //        var circumference = 2 * Math.PI * radius;
    //    }
    //}


    //You’re given a word string containing one or many $ symbols, e.g.:
    //"foo bar foo $ bar $ foo bar $ "
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        string s = "like for example $  you don't have $  network $  access";
    //        Console.WriteLine(ReplaceChar(s));
    //    }
    //    public static string ReplaceChar(string input)
    //    {
    //        Regex rgx = new Regex("\\$\\s+");
    //        input = Regex.Replace(input, @"(\$\s+.*?)\$\s+", "$1$$");
    //        return input;
    //    }
    //}


    //string length without using inbuild function
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        string name = "Wells Fargo EGS";
    //        int stringLength = GetStringLength(name);
    //        Console.WriteLine(stringLength);
    //        Console.WriteLine(name.Length);
    //    }

    //    private static int GetStringLength(string name)
    //    {
    //        bool status = true;
    //        int i = 0;
    //        name = name + '\0';
    //        while (status)
    //        {
    //            if (name[i] != '\0')
    //            {
    //                i++;
    //            }
    //            else
    //            {
    //                status = false;
    //            }
    //        }
    //        return i;

    // StringBuilder str = new StringBuilder(Name);
    //str.Append("\0");
    //int i = 0;
    //while(str[i] != '\0')
    //{
    //    i++;
    //}
    //    }
    //}


    class Program
    {
        static void Main(string[] args)
        {
            Print(10);
        }
        public static void Print(int level)
        {
            int i, space, print;
            for (i = 1; i <= level; i++)
            {
                for (space = 1; space < (level - i + 1); space++)
                {
                    Console.Write(" ");
                }
                for (print = 1; print <= i; print++)
                {
                    Console.Write("*"); // Console.Write("*"); replace this to print in asterik
                    Console.Write("*");
                }
                Console.WriteLine();
                Console.ReadLine();
            }
        }
    }
}
