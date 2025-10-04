using p4lmLibrary.CurrentPlayer;
using p4lmLibrary.Levels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace p4lmLibrary.Hub
{
    /// <summary>
    /// Hub for entry to p4lmLibrary + Info Gathering
    /// </summary>
    public class Hub
    {
        /// <summary>
        /// Engages startup sequence
        /// </summary>
        public void Engage()
        {
            InfoGather();
        }

        /// <summary>
        /// Gathers information about the player
        /// </summary>
        public void InfoGather()
        {
            Player player = new Player();

            Console.WriteLine("please enter your name...");
            player.Name = Console.ReadLine();
            Console.Clear();

            Console.WriteLine($"why hello {player.Name}.... are you ready for a challenge?");

            player.Auth = false;

            while (!player.Auth)
            {
                player.Decision = Console.ReadLine();

                switch (player.Decision)
                {
                    case "yes":
                        Console.Clear();
                        Console.WriteLine("perfect thats what we like to see");
                        Console.ReadKey();
                        Console.Clear();

                        player.CurrentLevel = new Intro();
                        player.Auth = true;

                        break;

                    case "no":
                        Console.Clear();
                        Console.WriteLine($"i am immensely disappointed in you {player.Name}... please rethink your choices");
                        Console.ReadKey();
                        Console.Clear();
                        Environment.Exit(0);

                        break;

                    default:
                        Console.WriteLine("i didnt understand that, type it in again");

                        break;
                }
            }
        }
    }
}
