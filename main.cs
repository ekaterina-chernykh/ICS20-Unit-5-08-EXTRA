// Created by: Ekaterina
// Created on: Dec 2022
//
// This program multiplies with and addition while loop

using System;

class Program
{
    public static void Main(string[] args)
    {
        int val1;
        int val2;
        int counter = 0;
        int result = 0;
        int val1pos;
        int val2pos;
        int remainder;

        Console.WriteLine(" ");
        Console.WriteLine("Simple long division:");
        Console.WriteLine(" ");
        Console.WriteLine("Enter 2 positive intergers:");
        Console.WriteLine(" ");

        val1 = Convert.ToInt16(Console.ReadLine());
        val2 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine(" ");

        val1pos = Math.Abs(val1);
        val2pos = Math.Abs(val2);
        remainder = val1pos;

        while (remainder >= val2pos)
        {
            remainder = remainder - val2pos;
            counter = counter + 1;
        }
        result = counter;
        if ((val1 < 0 && val2 > 0) || (val1 > 0 && val2 < 0))
        {
            result = result * -1;
        } 
        Console.Clear();
        Console.WriteLine("The result is: " + result + " R" + remainder);
        Console.WriteLine("\nDone.");
    }
}