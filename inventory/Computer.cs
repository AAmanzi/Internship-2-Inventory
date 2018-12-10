using System;
using System.Collections.Generic;
using System.Text;

namespace inventory
{
    public enum OS
    {
        Windows = 1,
        Linux = 2,
        MacOS = 3,
        Default = 4
    }
    public class Computer : Electronics
    {
        public OS OperativeSystem { get; set; }
        public bool IsPortable { get; set; }

        public Computer()
        {

        }

        public Computer(string description, string yearPurchased, string monthPurchased,
            string dayPurchased, string warrantyInMonths, string priceWhenPurchased, Company manufacturer, 
            bool hasBattery, OS operativeSystem, bool isPortable)

            : base(description, yearPurchased, monthPurchased,
                dayPurchased, warrantyInMonths, priceWhenPurchased, manufacturer, hasBattery)
        {
            OperativeSystem = operativeSystem;
            IsPortable = isPortable;
        }

        public new void Print()
        {
            base.Print();
            Console.WriteLine("Operative system: " + OperativeSystem);
            Console.WriteLine("Is portable: " + IsPortable);
        }
    }
}
