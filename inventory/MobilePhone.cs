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

        public MobilePhone(string description, string yearPurchased, string monthPurchased,
            string dayPurchased, string warrantyInMonths, string priceWhenPurchased, Company manufacturer, 
            string phoneNumber, string nameOfOwner, string lastNameOfOwner)

            : base(description, yearPurchased, monthPurchased, dayPurchased, 
                warrantyInMonths, priceWhenPurchased, manufacturer, true)
        {
            PhoneNumber = phoneNumber;
            NameOfOwner = nameOfOwner;
            LastNameOfOwner = lastNameOfOwner;
        }

        public new void Print()
        {
            base.Print();
            Console.WriteLine("Phone number: " + PhoneNumber);
            Console.WriteLine("Name of owner: " + NameOfOwner);
            Console.WriteLine("Last name of owner: " + LastNameOfOwner);
        }

        
    }

}
