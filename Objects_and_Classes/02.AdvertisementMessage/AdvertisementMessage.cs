using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AdvertisementMessage
{
    class AdvertisementMessage
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            
            string[] phrases = {"Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category."};
            string[] events = { "Now I feel good.", "I have succeeded to change.", "That makes miracles.", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied." };
            string[] author = {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Misha"};
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
            int phrasesRnd = rnd.Next(0, phrases.Length);
            int eventsRnd = rnd.Next(0, events.Length);
            int authorRnd = rnd.Next(0, author.Length);
            int citiesRnd = rnd.Next(0, cities.Length);
            Console.WriteLine($"{phrases[phrasesRnd]} {events[eventsRnd]} {author[authorRnd]} – {cities[citiesRnd]}");
        }
    }
}
