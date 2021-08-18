using System;
using System.Text.RegularExpressions;

namespace _03.SoftuniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string namePattern = @"%(?<name>[A-Z][a-z]+)%";
            string productPattern = @"<(?<product>\w+)>";
            string quantityPattern = @"\|(?<quantity>\d+)\|";
            string pricePattern = @"(?<price>\d+\.\d+|\d+)\$";
            string input = Console.ReadLine();
            decimal totalIncome = 0;
            while(input!="end of shift")
            {
                if (Regex.IsMatch(input,namePattern)&&Regex.IsMatch(input,productPattern)
                    &&Regex.IsMatch(input,quantityPattern)&&Regex.IsMatch(input,pricePattern))
                {
                    var resultName = Regex.Match(input,namePattern);
                    var resultProduct = Regex.Match(input,productPattern);
                    var resultQuantity = Regex.Match(input,quantityPattern);
                    var resultPrice = Regex.Match(input,pricePattern);
                    string name = resultName.Groups["name"].Value;
                    string product = resultProduct.Groups["product"].Value;

                    decimal price = int.Parse(resultQuantity.Groups["quantity"].Value) * decimal.Parse(resultPrice.Groups["price"].Value);
                    Console.WriteLine($"{name}: {product} - {price:F2}");
                    totalIncome += price;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {totalIncome:F2}");
        }
    }
}
