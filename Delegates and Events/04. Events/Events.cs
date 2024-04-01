using System;

namespace _04._Events
{
    public delegate void StringDelegate(string text);

    internal class Events
    {
        static void Main()
        {
            // delegates
            StringDelegate stringDelegate = ToUpperCase;
            stringDelegate("this is lower case");
            stringDelegate.Invoke("this is another lower case string");

            stringDelegate = ToLowerCase;
            stringDelegate.Invoke("THIS IS UPPER CASE");

            WriteOutput("this is a lower case string", ToUpperCase);

            // events
            Strings myString = new Strings();
            myString.stringEvent += TextChanged;

            string str;
            do
            {
                str = Console.ReadLine();
                if (!str.Equals("exit"))
                {
                    myString.Value = str;
                }
            } while (!str.Equals("exit"));
        }

        static void ToUpperCase(string text) => Console.WriteLine(text.ToUpper());
        static void ToLowerCase(string text) => Console.WriteLine(text.ToLower());

        static void TextChanged(string text) => Console.WriteLine($"You entered: {text}");

        static void WriteOutput(string text, StringDelegate stringDelegate)
        {
            Console.WriteLine($"Before: {text}");
            stringDelegate(text);
        }
    }

    public class Strings
    {
        private string stringValue;
        public event StringDelegate stringEvent;

        public string Value
        {
            set
            {
                this.stringValue = value;
                this.stringEvent(this.stringValue);
            }
        }
    }
}
