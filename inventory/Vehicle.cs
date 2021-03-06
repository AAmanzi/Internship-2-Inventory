﻿using System;
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

        public Vehicle(string description, string yearPurchased, string monthPurchased,
            string dayPurchased, string warrantyInMonths, string priceWhenPurchased, Company manufacturer, 
            string expireYear, string expireMonth, string expireDay, string distanceRanInKm)

            : base(description, yearPurchased, monthPurchased, dayPurchased, 
                  warrantyInMonths, priceWhenPurchased,manufacturer) 
        {
            LicenseExpireDate = LicenseExpireDate.AddYears(int.Parse(expireYear)-1);
            LicenseExpireDate = LicenseExpireDate.AddMonths(int.Parse(expireMonth)-1);
            LicenseExpireDate = LicenseExpireDate.AddDays(int.Parse(expireDay)-1);

            DistanceRanInKm = int.Parse(distanceRanInKm);
        }

        public new void Print()
        {
            base.Print();
            Console.WriteLine($"License expires: {LicenseExpireDate.Day}/{LicenseExpireDate.Month}/{LicenseExpireDate.Year}");
            Console.WriteLine("Distance ran: " + DistanceRanInKm + " Km");
        }

        public double ResellValue()
        {
            var newValue = (double)PriceWhenPurchased;
            var priceDropIndex = DistanceRanInKm / 20000;

            for (int i = 0; i < priceDropIndex; i++)
            {
                newValue = newValue * 0.9;
                if (newValue <= PriceWhenPurchased * 0.2)
                {
                    newValue = PriceWhenPurchased * 0.2;
                    break;
                }
            }
            newValue = Math.Round(newValue, 2);

            return newValue;
        }
    }
}
