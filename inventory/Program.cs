using System;
using System.Collections.Generic;

namespace inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            var allVehicles = InitiateVehicles();
            var allPhones = InitiatePhones();
            var allComputers = InitiateComputers();

            foreach (var car in allVehicles)
            {
                Console.WriteLine("Price when bought: " + car.PriceWhenPurchased);
                Console.WriteLine("Distance ran: " + car.DistanceRanInKm + "Km");
                Console.WriteLine("Resell value: " + car.ResellValue());
                Console.WriteLine();
            }

            foreach (var phone in allPhones)
            {
                Console.WriteLine("Price when bought: " + phone.PriceWhenPurchased);
                Console.WriteLine("Resell value: " + phone.ResellValue());
                Console.WriteLine();
            }
        }



        static Company StringToCompany(string company)
        {
            company.Replace(" ", "");
            company = company.ToLower();
            switch (company)
            {
                case "fiat":
                    return Company.Fiat;
                case "lancia":
                    return Company.Lancia;
                case "alfa":
                    return Company.Alfa;
                case "volkswagen":
                    return Company.Volkswagen;
                case "mercedes":
                    return Company.Mercedes;
                case "audi":
                    return Company.Audi;
                case "bmw":
                    return Company.BMW;
                case "citroen":
                    return Company.Citroen;
                case "peugeot":
                    return Company.Peugeot;
                case "opel":
                    return Company.Opel;

                case "samsung":
                    return Company.Samsung;
                case "apple":
                    return Company.Apple;
                case "huawei":
                    return Company.Huawei;
                case "sony":
                    return Company.Sony;
                case "xiaomi":
                    return Company.Xiaomi;

                case "asus":
                    return Company.Asus;
                case "acer":
                    return Company.Acer;
                case "hp":
                    return Company.HP;
                case "dell":
                    return Company.Dell;
                case "lenovo":
                    return Company.Lenovo;
                default:
                    Console.WriteLine("\nThat is not a valid manufacturer!\n");
                    return Company.Default;
            }
        }

        static OS StringToOS(string operatingSystem) //needs testing
        {
            operatingSystem.Replace(" ", "");
            operatingSystem.ToLower();
            switch(operatingSystem)
            {
                case "windows":
                    return OS.Windows;
                case "linux":
                    return OS.Linux;
                case "mac":
                case "macos":
                    return OS.MacOS;
                default:
                    Console.WriteLine("\nThat is not a valid Operating System!\n");
                    return OS.Default;
            }
        }

        static List<Vehicle> InitiateVehicles()
        {
            var allVehicles = new List<Vehicle>()
            {
                new Vehicle("", "2010", "7", "13", "60", "100000", Company.Alfa, "2020", "7", "13", "120000"),
                new Vehicle("", "2007", "10", "23", "60", "120000", Company.Lancia, "2019", "10", "23", "210000"),
                new Vehicle("", "2016", "1", "19", "60", "240000", Company.Volkswagen, "2024", "1", "19", "60000"),
                new Vehicle("", "2012", "6", "24", "60", "260000", Company.Audi, "2022", "6", "24", "150000"),
                new Vehicle("", "1996", "12", "1", "60", "90000", Company.Citroen, "2019", "2", "19", "170000"),
            };
            return allVehicles;
        }

        static List<MobilePhone> InitiatePhones()
        {
            var allPhones = new List<MobilePhone>()
            {
                new MobilePhone("", "2018", "4", "24", "12", "1000", Company.Xiaomi, "091123", "name1", "lname1"),
                new MobilePhone("", "2017", "9", "17", "24", "7000", Company.Apple, "091456", "name2", "lname2"),
                new MobilePhone("", "2016", "7", "6", "12", "6500", Company.Samsung, "091789", "name3", "lname3"),
            };
            return allPhones;
        }

        static List<Computer> InitiateComputers()
        {
            var allComputers = new List<Computer>()
            {
                new Computer("", "2018", "4", "30", "12", "7500", Company.HP, false, OS.Windows, false),
                new Computer("", "2017", "9", "3", "12", "7000", Company.Lenovo, true, OS.Linux, true),
                new Computer("", "2018", "6", "24", "12", "8500", Company.Apple, true, OS.MacOS, true),
            };
            return allComputers;
        }

        static void DeleteProduct(string toDeleteSerialNumber, List<Vehicle> allVehicles,
            List<MobilePhone> allPhones, List<Computer> allComputers)
        {
            foreach (var vehicle in allVehicles)
            {
                if (vehicle.SerialNumber.ToString().ToLower().Contains(toDeleteSerialNumber.ToLower()))
                {
                    allVehicles.Remove(vehicle);
                    return;
                }
            }
            foreach (var phone in allPhones)
            {
                if (phone.SerialNumber.ToString().ToLower().Contains(toDeleteSerialNumber.ToLower()))
                {
                    allPhones.Remove(phone);
                    return;
                }
            }
            foreach (var computer in allComputers)
            {
                if (computer.SerialNumber.ToString().ToLower().Contains(toDeleteSerialNumber.ToLower()))
                {
                    allComputers.Remove(computer);
                    return;
                }
            }
            Console.WriteLine("\nNo product with that serial number has been found!\n");
        }

        static void PrintAllVehicles(List<Vehicle> allVehicles)
        {
            foreach (var vehicle in allVehicles)
            {
                vehicle.Print();
                Console.WriteLine();
            }
        }

        static void PrintAllPhones(List<MobilePhone> allPhones)
        {
            foreach (var phone in allPhones)
            {
                phone.Print();
                Console.WriteLine();
            }   
        }

        static void PrintAllComputers(List<Computer> allComputers)
        {
            foreach (var computer in allComputers)
            {
                computer.Print();
                Console.WriteLine();
            }
        }

        static void PrintAllProducts(List<Vehicle> allVehicles,
            List<MobilePhone> allPhones, List<Computer> allComputers)
        {
            Console.WriteLine("VEHICLES:\n\n");
            PrintAllVehicles(allVehicles);
            Console.WriteLine();
            
            Console.WriteLine("PHONES:\n\n");
            PrintAllPhones(allPhones);
            Console.WriteLine();

            Console.WriteLine("COMPUTERS:\n\n");
            PrintAllComputers(allComputers);
            Console.WriteLine();
        }

        static void PrintProductBySerial(string serialNumber, List<Vehicle> allVehicles,
            List<MobilePhone> allPhones, List<Computer> allComputers)
        {
            serialNumber.Replace(" ", "-").Replace("_", "-").Replace(".", "-");
            foreach (var vehicle in allVehicles)
            {
                if (vehicle.SerialNumber.ToString().ToLower().Contains(serialNumber.ToLower()))
                {
                    vehicle.Print();
                    return;
                }
            }
            foreach (var phone in allPhones)
            {
                if (phone.SerialNumber.ToString().ToLower().Contains(serialNumber.ToLower()))
                {
                    phone.Print();
                    return;
                }
            }
            foreach (var computer in allComputers)
            {
                if (computer.SerialNumber.ToString().ToLower().Contains(serialNumber.ToLower()))
                {
                    computer.Print();
                    return;
                }
            }
            Console.WriteLine("\nNo product with that serial number has been found!\n");
        }

        static void PrintComputersWarrantyEndingIn(string inputYear, List<Computer> allComputers)
        {
            inputYear.Replace(" ", "");

            foreach (var computer in allComputers)
            {
                var warrantyEndYear = computer.DatePurchased.AddMonths(computer.WarrantyInMonths).Year;
                if (warrantyEndYear == int.Parse(inputYear))
                {
                    computer.Print();
                    Console.WriteLine();
                }
            }
        }

        static int NumberOfProductsWithBatteries(List<MobilePhone> allPhones, List<Computer> allComputers)//needs testing
        {
            var countBatteries = 0;

            foreach (var phone in allPhones)
            {
                if (phone.HasBattery == true)
                    countBatteries++;
            }

            foreach (var computer in allComputers)
            {
                if (computer.HasBattery == true)
                    countBatteries++;
            }

            return countBatteries;
        }

        static void PrintPhoneByManufacturer(Company manufacturerForSearch, List<MobilePhone> allPhones)//needs testing
        {
            foreach (var phone in allPhones)
            {
                if (phone.Manufacturer == manufacturerForSearch)
                    phone.Print();
            }
        }

        static void PrintPhoneUsersWarrantyEndingIn(string inputYear, List<MobilePhone> allPhones)//needs testing
        {
            inputYear.Replace(" ", "");
            foreach (var phone in allPhones)
            {
                var warrantyEndYear = phone.DatePurchased.AddMonths(phone.WarrantyInMonths).Year;
                if (warrantyEndYear == int.Parse(inputYear))
                {
                    Console.WriteLine("Name: " + phone.NameOfOwner);
                    Console.WriteLine("Last name: " + phone.LastNameOfOwner);
                    Console.WriteLine("Phone number: " + phone.PhoneNumber);
                    Console.WriteLine();
                }
            }
        }

        static void PrintVehiclesLincenseEndingNextMonth(List<Vehicle> allVehicles)//needs testing
        {
            var monthSearch = DateTime.Now.Month + 1;
            var yearSearch = DateTime.Now.Year;
            if (monthSearch == 1)
                yearSearch++;
            foreach (var vehicle in allVehicles)
            {
                var monthExpires = vehicle.LicenseExpireDate.Month;
                var yearExpires = vehicle.LicenseExpireDate.Year;

                if (monthSearch == monthExpires && yearSearch == yearExpires)
                {
                    vehicle.Print();
                    Console.WriteLine();
                }
            }
        }


    }
}
