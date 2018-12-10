using System;

namespace inventory
{
    class Program
    {
        static void Main(string[] args)
        {

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
    }
}
