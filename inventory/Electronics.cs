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

        public double ResellValue()
        {
            var newValue = (double)PriceWhenPurchased;
            var priceDropIndex = (int)(DateTime.Now.Subtract(DatePurchased).TotalDays / 30);

            Console.WriteLine("index: " + priceDropIndex);

            for (int i = 0; i < priceDropIndex; i++)
            {
                newValue = newValue * 0.05;
                if (newValue <= PriceWhenPurchased * 0.3)
                {
                    newValue = PriceWhenPurchased * 0.3;
                    break;
                }
            }

            newValue = Math.Round(newValue, 2);
            return newValue;
        }
    }
}
