using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.Food
{
    class IceCream
    {
        public bool IsCreamy { get; set; }
        public bool IsChocolate { get; set; }

        public void Noms()
        {
            if (IsChocolate)
            {
                Console.WriteLine("Ice Cream is always better with chocolate.");
            }
            else
            {
                Console.WriteLine("Nothing better than creamy ice cream.");
            }
        }
    }
}
