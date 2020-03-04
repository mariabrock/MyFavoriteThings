using System;
using MyFavoriteThings.Food;
using MyFavoriteThings.Books;
using MyFavoriteThings.Games;
using MyFavoriteThings.People;

namespace MyFavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var cookieDough = new IceCream();
            cookieDough.IsCreamy = true;

            cookieDough.Noms();

            var lordOfTheRings = new Fantasy();
            lordOfTheRings.IsOld = false;

            lordOfTheRings.Read();

            var settlersOfCatan = new BoardGames();
            settlersOfCatan.IsLong = true;

            settlersOfCatan.Play();

            var husband = new Family();
            husband.IsPhillip = true;

            husband.Hello();

            Console.ReadKey();
        }
    }
}
