using System;
using System.Collections.Generic;

namespace ExerciseObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> phrases = new List<string>
                {"Excellent product.", "Such a great product.",
                "I always use that product.", "Best product of its category.",
            "Exceptional product.", "I can’t live without this product."};

            List<string> events = new List<string>
           {
                "Now I feel good.", "I have succeeded with this product.",
               "Makes miracles. I am happy of the results!",
                   "I cannot believe but now I feel awesome.",
               "Try it yourself, I am very satisfied.", "I feel great!"
           };
            List<string> authors = new List<string>
            {
                "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
            };
            List<string> cities = new List<string>
            {
                "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
            };

           
            List<Message> messages = new List<Message>();
           
            for (int i = 0; i < n; i++)
            {
                Random rnd = new Random();
                int index = rnd.Next(authors.Count - 1);
                Message message = new Message();
                if (index >= phrases.Count)
                {
                    int newIndex = phrases.Count - 1;
                    message.Phrases=phrases[newIndex];
                }
                else
                {
                    message.Phrases=phrases[index];
                }
                if (index >= events.Count)
                {
                    int newIndex = events.Count - 1 ;
                    message.Events=events[newIndex];
                }
                else
                {
                    message.Events=events[index];
                }

                message.Authors=authors[index];
                if (index >= cities.Count)
                {
                    int newIndex = cities.Count - 1;
                }
                else
                {
                    message.Cities = cities[index];
                }
                messages.Add(message);
            }

            foreach (Message message in messages)
            {
                Console.WriteLine($"{message.Phrases} {message.Events} {message.Authors} - {message.Cities}");
            }

           



        }
    }

    public class Message
    {
        public string Phrases { get; set; }
        public string Events { get; set; }
        public string Authors { get; set; }
        public string Cities { get; set; }


    }

}
