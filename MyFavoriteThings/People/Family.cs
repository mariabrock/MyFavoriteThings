using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.People
{
    class Family
    {
        public bool IsPhillip { get; set; }
        public bool IsMom { get; set; }

        public void Hello()
        {
            if (IsPhillip)
            {
                Console.WriteLine("You're my favorite.");
            }
            else
            {
                Console.WriteLine("Hi Mom!");
            }
        }
    }
}
