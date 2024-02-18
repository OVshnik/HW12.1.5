
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> listUsers = new()
        { new User ("Ivan","ivan@66", true),
        new User ("Bob","bob_33",false),
        new User ("Jo","jo_55",true)};

            foreach (var item in listUsers)
            {
                if (item.IsPremium == true)
                {
                    Console.WriteLine($"{item.Name} добро пожаловать!");
                }
                else
                {
                    Console.Write($"{item.Name} ");
                    ShowAds();
                }
            }
            Console.ReadKey();
        }
        
        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
    }
}