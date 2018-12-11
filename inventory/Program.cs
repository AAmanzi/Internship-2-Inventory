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
            while (true) //add break
            {
                PrintMenu();

                var choice = Console.ReadLine().Replace(" ", "");

                switch (choice)
                {
                    case "1": //Print all products
                        PrintAllProducts(allVehicles, allPhones, allComputers);
                        break;
                    case "2": //Print all vehicles 
                        PrintAllVehicles(allVehicles);
                        break;
                    case "3": //Print all phones
                        PrintAllPhones(allPhones);
                        break;
                    case "4": //Print all computers
                        PrintAllComputers(allComputers);
                        break;

                    case "5": //Add a vehicle
                        Console.WriteLine("Enter description: ");
                        var newDescription = Console.ReadLine();
                        Console.WriteLine("Enter year purchased: ");
                        var newYearPurchased = Console.ReadLine();
                        Console.WriteLine("Enter month purchased: ");
                        var newMonthPurchased = Console.ReadLine();
                        Console.WriteLine("Enter day purchased: ");
                        var newDayPurchased = Console.ReadLine();
                        Console.WriteLine("Enter lenght of warranty in months: ");
                        var newWarrantyInMonths = Console.ReadLine();
                        Console.WriteLine("Enter price when purchased: ");
                        var newPriceWhenPurchased = Console.ReadLine().Replace(" ", "").Replace(",", "");
                        Console.WriteLine("Enter manufacturer: ");
                        var newManufacturer = StringToCompany(Console.ReadLine());

                        Console.WriteLine("Enter year of license expiry: ");
                        var newExpireYear = Console.ReadLine();
                        Console.WriteLine("Enter month of license expiry: ");
                        var newExpireMonth = Console.ReadLine();
                        Console.WriteLine("Enter day of license expiry: ");
                        var newExpireDay = Console.ReadLine();
                        Console.WriteLine("Enter distance ran in kilometers: ");
                        var newDistanceRanInKm = Console.ReadLine();

                        allVehicles.Add(new Vehicle(newDescription, newYearPurchased, newMonthPurchased,
                            newDayPurchased, newWarrantyInMonths, newPriceWhenPurchased, newManufacturer,
                            newExpireYear, newExpireMonth, newExpireDay, newDistanceRanInKm));
                        break;
                    case "6": //Add a phone
                        Console.WriteLine("Enter description: ");
                        newDescription = Console.ReadLine();
                        Console.WriteLine("Enter year purchased: ");
                        newYearPurchased = Console.ReadLine();
                        Console.WriteLine("Enter month purchased: ");
                        newMonthPurchased = Console.ReadLine();
                        Console.WriteLine("Enter day purchased: ");
                        newDayPurchased = Console.ReadLine();
                        Console.WriteLine("Enter lenght of warranty in months: ");
                        newWarrantyInMonths = Console.ReadLine();
                        Console.WriteLine("Enter price when purchased: ");
                        newPriceWhenPurchased = Console.ReadLine().Replace(" ", "").Replace(",", "");
                        Console.WriteLine("Enter manufacturer: ");
                        newManufacturer = StringToCompany(Console.ReadLine());

                        Console.WriteLine("Enter phone number: ");
                        var newPhoneNumber = Console.ReadLine().Replace(" ", "");
                        Console.WriteLine("Enter name of owner: ");
                        var newNameOfOwner = Console.ReadLine().Replace(" ", "");
                        Console.WriteLine("Enter last name of owner: ");
                        var newLastNameOfOwner = Console.ReadLine().Replace(" ", "");

                        allPhones.Add(new MobilePhone(newDescription, newYearPurchased, newMonthPurchased,
                            newDayPurchased, newWarrantyInMonths, newPriceWhenPurchased, newManufacturer,
                            newPhoneNumber, newNameOfOwner, newLastNameOfOwner));
                        break;
                    case "7": //Add a computer
                        Console.WriteLine("Enter description: ");
                        newDescription = Console.ReadLine();
                        Console.WriteLine("Enter year purchased: ");
                        newYearPurchased = Console.ReadLine();
                        Console.WriteLine("Enter month purchased: ");
                        newMonthPurchased = Console.ReadLine();
                        Console.WriteLine("Enter day purchased: ");
                        newDayPurchased = Console.ReadLine();
                        Console.WriteLine("Enter lenght of warranty in months: ");
                        newWarrantyInMonths = Console.ReadLine();
                        Console.WriteLine("Enter price when purchased: ");
                        newPriceWhenPurchased = Console.ReadLine().Replace(" ", "").Replace(",", "");
                        Console.WriteLine("Enter manufacturer: ");
                        newManufacturer = StringToCompany(Console.ReadLine());

                        Console.WriteLine("Does the computer have a battery: ");
                        Console.WriteLine("\tPress Y for Yes");
                        Console.WriteLine("\tPress anything else for No\n");
                        var newHasBattery = Console.ReadKey().Key == ConsoleKey.Y;
                        Console.WriteLine();
                        Console.WriteLine("Enter OS: ");
                        var newOS = StringToOS(Console.ReadLine());
                        Console.WriteLine("Is the computer portable: ");
                        Console.WriteLine("\tPress Y for Yes");
                        Console.WriteLine("\tPress anything else for No\n");
                        var newIsPortable = Console.ReadKey().Key == ConsoleKey.Y;
                        Console.WriteLine();

                        allComputers.Add(new Computer(newDescription, newYearPurchased, newMonthPurchased,
                            newDayPurchased, newWarrantyInMonths, newPriceWhenPurchased, newManufacturer,
                            newHasBattery, newOS, newIsPortable));
                        break;
                    
                }
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

        static OS StringToOS(string operatingSystem)
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

        static void PrintMenu()
        {
            Console.WriteLine(" ____________________________________________________");
            Console.WriteLine("|                                                    |");
            Console.WriteLine("| 1)  Print all products                             |");
            Console.WriteLine("| 2)  Print all vehicles                             |");
            Console.WriteLine("| 3)  Print all phones                               |");
            Console.WriteLine("| 4)  Print all computers                            |");
            Console.WriteLine("|____________________________________________________|");
            Console.WriteLine("|                                                    |");
            Console.WriteLine("| 5)  Add a vehicle                                  |");
            Console.WriteLine("| 6)  Add a phone                                    |");
            Console.WriteLine("| 7)  Add a computer                                 |");
            Console.WriteLine("|____________________________________________________|");
            Console.WriteLine("|                                                    |");
            Console.WriteLine("| 8)  Delete a product                               |");
            Console.WriteLine("|____________________________________________________|");
            Console.WriteLine("|                                                    |");
            Console.WriteLine("| 9)  Search product                                 |");
            Console.WriteLine("| 10) Search computer with warranty ending in year   |");
            Console.WriteLine("| 11) Search phones with warranty ending in year     |");
            Console.WriteLine("| 12) Search vehicles with lincese ending next month |");
            Console.WriteLine("| 13) Search products with batteries                 |");
            Console.WriteLine("| 14) Search phones by manufacturer                  |");
            Console.WriteLine("| 15) Search computers by OS                         |");
            Console.WriteLine("|____________________________________________________|");
            Console.WriteLine("|                                                    |");
            Console.WriteLine("| 16) Print all resell value information             |");
            Console.WriteLine("| 17) Print vehicle resell value information         |");
            Console.WriteLine("| 18) Print electronics resell value information     |");
            Console.WriteLine("|____________________________________________________|");
            Console.WriteLine("|                                                    |");
            Console.WriteLine("| 19) Exit application                               |");
            Console.WriteLine("|____________________________________________________|");
        }
    }
}
