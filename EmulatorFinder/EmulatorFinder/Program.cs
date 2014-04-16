using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmulatorFinder
{
    class Program
    {
        static void Main(string[] args)
        {
           

                List<String> emu = new List<String> (4) { "Ps1", "N64", "Gba", "Mame" };
                List<String> games = new List<String>(4) { " Bloody roar 2", "Super smash Bros", "Pokemon Emerald", "Marvel vs Capcom" };

                Console.WriteLine("Enter the name of the console you wish to play: Ps1, N64, GBA, MAME. ");
                String input = Console.ReadLine();

                for(int i = 1; i < emu.Count; i ++)
                {
                if (input == emu[0])
                {
                    Console.WriteLine("{0} is avaliable for play", games[0]);
                }
                else if (input == emu[1])
                {
                    Console.WriteLine("{0} is avaliable for play", games[1]);
                }
                else if (input == emu[2])
                {
                    Console.WriteLine("{0} is avaliable for play", games[2]);
                }
                else if (input == emu[3])
                {
                    Console.WriteLine("{0} is abaliable for play", games[3]);
                }
                else if (input != emu[i])
                {
                    Console.WriteLine("Sorry we do not have your console for play");
 
                }

                
            }




        }
    }
}
