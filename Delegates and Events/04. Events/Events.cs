using System;

namespace _04._Events
{
    public delegate void StringDelegate(string text);

    internal class Events
    {
        static void Main()
        {
            StringDelegate stringDelegate = ToUpperCase;
            stringDelegate("this is lower case");
            stringDelegate.Invoke("this is another lower case string");

            stringDelegate = ToLowerCase;
            stringDelegate.Invoke("THIS IS UPPER CASE");
        }

        static void ToUpperCase(string text) => Console.WriteLine(text.ToUpper());
        static void ToLowerCase(string text) => Console.WriteLine(text.ToLower());

        static void WriteOutput(string text, StringDelegate stringDelegate)
        {
            Console.WriteLine($"Before: {text}");
        }
    }
}