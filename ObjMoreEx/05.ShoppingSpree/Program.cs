using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string personInput = Console.ReadLine();
            string[] personArgs = personInput
                    .Split(new char[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < personArgs.Length; i += 2)
            {
                string name = personArgs[i].ToString();
                decimal money = decimal.Parse(personArgs[i + 1].ToString());
                Person person = new Person(name, money);
                people.Add(person);
            }
            List<Product> products = new List<Product>();
            string productInput = Console.ReadLine();
            string[] productArgs = productInput
                .Split(new char[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < productArgs.Length; i += 2)
            {
                string name = productArgs[i];
                decimal price = decimal.Parse(productArgs[i + 1]);
                Product product = new Product(name, price);
                products.Add(product);
            }
            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] inputSplit = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string personName = inputSplit[0];
                string productName = inputSplit[1];
                int index = 0;
                foreach (var person in people)
                {
                    if(person.Name==personName)
                    {
                        foreach (var product in products)
                        {
                            if(productName==product.Name)
                            {
                                if(person.Money>=product.Price)
                                {
                                    person.Money -= product.Price;
                                    index = people.FindIndex(x => x.Name == personName);
                                    people[index].Products.Add(productName);
                                    Console.WriteLine($"{personName} bought {productName}");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine($"{personName} can't afford {productName}");
                                    break;
                                }
                            }
                        }
                        break;
                    }
                }


                input = Console.ReadLine();
            }

            foreach (var person in people.Where(x=> x.Products.Count>0))
            {
                Console.WriteLine($"{person.Name} - {String.Join(", ",person.Products)}");
            }
            foreach (var person in people.Where(x=> x.Products.Count==0))
            {
                Console.WriteLine($"{person.Name} - Nothing bought");
            }
        }
    }

    class Person
    {
        public string Name { get; set; }
        public decimal Money { get; set; }
        public List<string> Products;

        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            Products = new List<string>();
        }
       

    }

    class Product
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

    }
}
