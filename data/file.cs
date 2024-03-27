using System;


public class data{
    static void Main(string[] args){
        Console.WriteLine("Enter int value : ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter float value : ");
        float f = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine("Enter a string : ");
        string s = Console.ReadLine();

        Console.WriteLine("Enter bool (true or false) : ");
        bool b = Convert.ToBoolean(Console.ReadLine());

        Console.WriteLine("Enter char : ");
        char c = Convert.ToChar(Console.ReadLine());

        Console.WriteLine($" {n} is integer !");
        Console.WriteLine($" {f} is float !");
        Console.WriteLine($" {s} is string !");
        Console.WriteLine($" {b} is boolean !");
        Console.WriteLine($" {c} is char !");

    }
}