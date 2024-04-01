using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._AlcoholEvents
{
    internal class Person
    {
        // 1- Define a delegate
        public delegate void DrinkDrankEventHandler(object source, EventArgs args);

        // 2- Define an event based on that delegate
        public event DrinkDrankEventHandler DrinkDrank;
    }
}
