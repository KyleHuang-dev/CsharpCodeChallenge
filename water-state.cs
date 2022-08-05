/**
Water is a unique matter because it is the only natural substance that can exist in all three states of matter at the temperatures commonly found on Earth! Water is usually a liquid, but when it reaches 0° Celsius (C), it freezes into ice (ice is the solid-state of water). When water reaches 100° C, it boils and becomes Gas. Write a program that asks the user to enter a temperature in Celsius. Your program should determine the state of water at this temperature. (Find two solutions, one using conditional if statements, and the other with a single line Ternary (?) operator.)


*/

using System;



class Program
{
    static void Main(string[] args)
    {
        int temperature;
        Console.WriteLine("Enter a temperature:");
        temperature = int.Parse(Console.ReadLine());

        string state = temperature <= 0 ? "Solid"
          : temperature > 100 ? "Gas"
          : "Liquid";

        Console.WriteLine(state);
        Console.Read();
    }

}



