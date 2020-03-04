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

            var lordOfTheRings = new Fantasy();
            lordOfTheRings.IsOld = false;

            var settlersOfCatan = new BoardGames();
            settlersOfCatan.IsLong = true;

            var husband = new Family();
            husband.IsPhillip = true;

            Console.ReadKey();
        }
    }
}
