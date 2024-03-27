using System;
using static System.Console;
public class data_type{
    public static void main(string[] args){
        WriteLine("Enter int value : ");
        int n = Convert.ToInt32(Readline());

        WriteLine("Enter float value : ");
        float f = Convert.ToSingle(Readline());

        WriteLine("Enter a string : ");
        string s = Readline();

        WriteLine("Enter bool (true or false) : ");
        bool b = Convert.ToBoolean(Readline());

        WriteLine("Enter char : ");
        char c = Convert.ToChar(Readline());

        WriteLine($" {n} is integer !");
        WriteLine($" {f} is float !");
        WriteLine($" {s} is string !");
        WriteLine($" {b} is boolean !");
        WriteLine($" {c} is char !");

    }
}