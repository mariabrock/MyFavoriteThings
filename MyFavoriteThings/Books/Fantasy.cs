using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.Books
{
    class Fantasy
    {
        public bool IsOld { get; set; }
        public bool SmellsGood { get; set; }

        public void Read()
        {
            if (IsOld)
            {
                Console.WriteLine("You hear a soft rustle of paper.");
            }
            else
            {
                Console.WriteLine("All you smell is paper.");
            }
        }

    }
}
