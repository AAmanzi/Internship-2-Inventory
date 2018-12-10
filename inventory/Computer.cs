using System;
using System.Collections.Generic;
using System.Text;

namespace inventory
{
    public class Computer : Electronics
    {
        public string OperativeSystem { get; set; }
        public bool IsPortable { get; set; }

        public Computer()
        {

        }

        public Computer(int serialNumber, string description, int yearPurchased, int monthPurchased,
            int dayPurchased, int warrantyInMonths, double priceWhenPurchased, Company manufacturer, 
            bool hasBattery, string operativeSystem, bool isPortable)

            : base(serialNumber, description, yearPurchased, monthPurchased,
                dayPurchased, warrantyInMonths, priceWhenPurchased, manufacturer, hasBattery)
        {
            OperativeSystem = operativeSystem;
            IsPortable = isPortable;
        }
    }
}
