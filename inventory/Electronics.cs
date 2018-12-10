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

        public Electronics(int serialNumber, string description, int yearPurchased, int monthPurchased,
            int dayPurchased, int warrantyInMonths, double priceWhenPurchased, Company manufacturer, bool hasBattery)

            : base(serialNumber, description, yearPurchased, monthPurchased,
                dayPurchased, warrantyInMonths, priceWhenPurchased, manufacturer)
        {
            HasBattery = hasBattery;
        }
    }
}
