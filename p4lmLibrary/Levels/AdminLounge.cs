using p4lmLibrary.CurrentPlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4lmLibrary.Levels
{
    /// <summary>
    /// admin lounge
    /// </summary>
    public class AdminLounge : Level
    {
        /// <summary>
        /// admin lounge level
        /// </summary>
        public AdminLounge()
        {
            TotalEnemies = 0;
            TotalSecrets = 0;
            I = true;
            II = true;
        }

        /// <summary>
        /// starts admin lounge
        /// </summary>
        public override void Start(Player player)
        {
            Console.WriteLine($"waddup {player.Name}, this is the admin lounge");
            Console.ReadKey();
            Console.Clear();

            while (!III)
            {
                player.Auth = false;

                while (!player.Auth)
                {
                    Console.WriteLine("what do you wanna do?:");
                    Console.WriteLine("(1) Commands (2) exit");

                    player.Decision = Console.ReadLine();
                    Console.Clear();

                    switch (player.Decision)
                    {
                        case "1":


                            break;

                        case "2":
                            player.Auth = true;
                            III = true;

                            Console.WriteLine($"you are now leaving the admin lounge {player.Name}... see you next time");
                            Console.ReadKey();
                            Console.Clear();

                            break;

                        default:
                            Console.WriteLine("i didnt recognize that...");

                            break;
                    }
                }
            }
        }
    }
}