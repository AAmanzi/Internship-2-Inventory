using System;
using System.Collections.Generic;
using System.Text;

namespace inventory
{
    public class MobilePhone : Electronics
    {
        public string PhoneNumber { get; set; }
        public string NameOfOwner { get; set; }
        public string LastNameOfOwner { get; set; }

        public MobilePhone()
        {

        }

        public MobilePhone(int serialNumber, string description, int yearPurchased, int monthPurchased,
            int dayPurchased, int warrantyInMonths, double priceWhenPurchased, Company manufacturer, 
            bool hasBattery, string phoneNumber, string nameOfOwner, string lastNameOfOwner)

            : base(serialNumber, description, yearPurchased, monthPurchased, dayPurchased, 
                warrantyInMonths, priceWhenPurchased, manufacturer, hasBattery)
        {
            PhoneNumber = phoneNumber;
            NameOfOwner = nameOfOwner;
            LastNameOfOwner = lastNameOfOwner;
        }
    }
}
