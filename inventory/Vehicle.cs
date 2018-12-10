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

        public Vehicle(int serialNumber, string description, int yearPurchased, int monthPurchased,
            int dayPurchased, int warrantyInMonths, double priceWhenPurchased, string manufacturer, 
            int expireYear, int expireMonth, int expireDay, int distanceRanInKm)

            : base(serialNumber, description, yearPurchased, monthPurchased, dayPurchased, 
                  warrantyInMonths, priceWhenPurchased,manufacturer) 
        {
            LicenseExpireDate = LicenseExpireDate.AddYears(expireYear-1);
            LicenseExpireDate = LicenseExpireDate.AddMonths(expireMonth-1);
            LicenseExpireDate = LicenseExpireDate.AddDays(expireDay-1);

            DistanceRanInKm = distanceRanInKm;
        }
    }
}
