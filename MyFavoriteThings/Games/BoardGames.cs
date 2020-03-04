using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.Games
{
    class BoardGames
    {
        public bool IsFun { get; set; }
        public bool IsLong { get; set; }

        public void Play()
        {
            if (IsFun)
            {
                Console.WriteLine("Let's play again!");
            }
            else
            {
                Console.WriteLine("This game is so looooooooong.");
            }
        }
    }
}
