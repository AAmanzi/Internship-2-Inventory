using System;
using System.Collections.Generic;
using System.Text;

namespace inventory
{ 
    public enum Company
    {
        Fiat = 1,
        Lancia = 2,
        Alfa = 3,
        Volkswagen = 4,
        Mercedes = 5,
        Audi = 6,
        BMW = 7,
        Citroen = 8,
        Peugeot = 9,
        Opel = 10,

        Samsung = 11,
        Apple = 12,
        Huawei = 13,
        Sony = 14,
        Xiaomi = 15,

        Asus = 16,
        Acer = 17,
        HP = 18,
        Dell = 19,
        Lenovo = 20,

        Default = 21
    }
    public class Product
    {
        public int SerialNumber{ get; set; }
        public string Description { get; set; }
        public DateTime DatePurchased { get; set; }
        public int WarrantyInMonths { get; set; }
        public double PriceWhenPurchased { get; set; }
        public Company Manufacturer { get; set; }

        public Product()
        {

        }

        public Product(int serialNumber, string description, int yearPurchased, int monthPurchased,
            int dayPurchased, int warrantyInMonths, double priceWhenPurchased, Company manufacturer)
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
