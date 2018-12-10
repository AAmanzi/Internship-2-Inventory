using System;
using System.Collections.Generic;
using System.Text;

namespace inventory
{
    public class Electronics : Product
    {
        public bool HasBattery{ get; set; }

        public Electronics()
        {

        }

        public Electronics(string description, string yearPurchased, string monthPurchased,
            string dayPurchased, string warrantyInMonths, string priceWhenPurchased, Company manufacturer, bool hasBattery)

            : base(description, yearPurchased, monthPurchased,
                dayPurchased, warrantyInMonths, priceWhenPurchased, manufacturer)
        {
            HasBattery = hasBattery;
        }

        public new void Print()
        {
            base.Print();
            Console.WriteLine("Has battery: " + HasBattery);
        }
    }
}
