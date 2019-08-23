﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing_2._11_Static_variables
{
    class Program
    {
        class Alien {
            public static readonly int Max_lives = 99;
            public int X;
            public int Y;
            public int Lives;
            public Alien(int x,int y,int lives) {
                if (x < 0 || y < 0)
                    throw new Exception("Invalid position");
                if (lives > Max_lives)
                    throw new Exception("Invalid lives");

                X = x;
                Y = y;
                Lives = lives;
            }
            public override string ToString()
            {
                return string.Format("X:{0} Y:{1} Lives:{2} Max Lives:{3}",X,Y,Lives,Max_lives);
            }
        }
        static void Main(string[] args)
        {
            
            Alien alien = new Alien(100,100,10);
            Console.WriteLine("{0}",alien.ToString());
            Console.ReadKey();
        }
    }
}
