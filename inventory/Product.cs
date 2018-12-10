using System;
using System.Collections.Generic;
using System.Text;

namespace inventory
{
    public class Product
    {
        public int SerialNumber{ get; set; }
        public string Description { get; set; }
        public DateTime DatePurchased { get; set; }
        public int WarrantyInMonths { get; set; }
        public double PriceWhenPurchased { get; set; }
        public string Manufacturer { get; set; }

        public Product()
        {

        }

        public Product(int serialNumber, string description, int yearPurchased, int monthPurchased,
            int dayPurchased, int warrantyInMonths, double priceWhenPurchased, string manufacturer)
        {
            DatePurchased = DatePurchased.AddYears(yearPurchased-1);
            DatePurchased = DatePurchased.AddMonths(monthPurchased-1);
            DatePurchased = DatePurchased.AddDays(dayPurchased-1);

            SerialNumber = serialNumber;
            Description = description;
            WarrantyInMonths = warrantyInMonths;
            PriceWhenPurchased = priceWhenPurchased;
            Manufacturer = manufacturer;
        }
    }
}
