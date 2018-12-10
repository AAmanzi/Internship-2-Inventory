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

            PrintAllProducts(allVehicles, allPhones, allComputers);
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

        static List<Vehicle> InitiateVehicles()
        {
            var allVehicles = new List<Vehicle>()
            {
                new Vehicle("", 2010, 7, 13, 60, 100000, Company.Alfa, 2020, 7, 13, 120000),
                new Vehicle("", 2007, 10, 23, 60, 120000, Company.Lancia, 2019, 10, 23, 210000),
                new Vehicle("", 2016, 1, 19, 60, 240000, Company.Volkswagen, 2024, 1, 19, 60000),
                new Vehicle("", 2012, 6, 24, 60, 260000, Company.Audi, 2022, 6, 24, 150000),
                new Vehicle("", 1996, 12, 1, 60, 90000, Company.Citroen, 2019, 2, 19, 170000),
            };
            return allVehicles;
        }

        static List<MobilePhone> InitiatePhones()
        {
            var allPhones = new List<MobilePhone>()
            {
                new MobilePhone("", 2018, 4, 24, 12, 1000, Company.Xiaomi, "091123", "name1", "lname1"),
                new MobilePhone("", 2017, 9, 17, 24, 7000, Company.Apple, "091456", "name2", "lname2"),
                new MobilePhone("", 2016, 7, 6, 12, 6500, Company.Samsung, "091789", "name3", "lname3"),
            };
            return allPhones;
        }

        static List<Computer> InitiateComputers()
        {
            var allComputers = new List<Computer>()
            {
                new Computer("", 2018, 4, 30, 12, 7500, Company.HP, false, "windows", false),
                new Computer("", 2017, 9, 3, 12, 7000, Company.Lenovo, true, "linux", true),
                new Computer("", 2018, 6, 24, 12, 8500, Company.Asus, true, "windows", true),
            };
            return allComputers;
        }

        static void DeleteProduct(string toDeleteSerialNumber, List<Vehicle> allVehicles, 
            List<MobilePhone> allPhones, List<Computer> allComputers)
        {
            foreach (var vehicle in allVehicles)
            {
                if (vehicle.SerialNumber.ToString().ToLower() == toDeleteSerialNumber.ToLower())
                {
                    allVehicles.Remove(vehicle);
                    return;
                }
            }
            foreach (var phone in allPhones)
            {
                if (phone.SerialNumber.ToString().ToLower() == toDeleteSerialNumber.ToLower())
                {
                    allPhones.Remove(phone);
                    return;
                }
            }
            foreach (var computer in allComputers)
            {
                if (computer.SerialNumber.ToString().ToLower() == toDeleteSerialNumber.ToLower())
                {
                    allComputers.Remove(computer);
                    return;
                }
            }
            Console.WriteLine("\nNo product with that serial number has been found!\n");
        }

        static void PrintAllProducts(List<Vehicle> allVehicles,
            List<MobilePhone> allPhones, List<Computer> allComputers)
        {
            Console.WriteLine("VEHICLES:\n");
            foreach (var vehicle in allVehicles)
            {
                vehicle.Print();
                Console.WriteLine();
            }
            Console.WriteLine("\nPHONES:\n");
            foreach (var phone in allPhones)
            {
                phone.Print();
                Console.WriteLine();
            }
            Console.WriteLine("\nCOMPUTERS:\n");
            foreach (var computer in allComputers)
            {
                computer.Print();
                Console.WriteLine();
            }
        }
    }
}
