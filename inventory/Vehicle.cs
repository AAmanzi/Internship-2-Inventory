using System;
using System.Collections.Generic;
using System.Text;

namespace inventory
{
    public class Vehicle : Product
    {
        public DateTime LicenseExpireDate { get; set; }
        public int DistanceRanInKm { get; set; }

        public Vehicle()
        {

        }

        public Vehicle(string description, int yearPurchased, int monthPurchased,
            int dayPurchased, int warrantyInMonths, double priceWhenPurchased, Company manufacturer, 
            int expireYear, int expireMonth, int expireDay, int distanceRanInKm)

            : base(description, yearPurchased, monthPurchased, dayPurchased, 
                  warrantyInMonths, priceWhenPurchased,manufacturer) 
        {
            LicenseExpireDate = LicenseExpireDate.AddYears(expireYear-1);
            LicenseExpireDate = LicenseExpireDate.AddMonths(expireMonth-1);
            LicenseExpireDate = LicenseExpireDate.AddDays(expireDay-1);

            DistanceRanInKm = distanceRanInKm;
        }

        public new void Print()
        {
            base.Print();
            Console.WriteLine($"License expires: {LicenseExpireDate.Day}/{LicenseExpireDate.Month}/{LicenseExpireDate.Year}");
            Console.WriteLine("Distance ran: " + DistanceRanInKm + " Km");
        }
    }
}
