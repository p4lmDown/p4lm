using p4lmLibrary.CurrentPlayer;
using p4lmLibrary.Enemies;
using p4lmLibrary.Healables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace p4lmLibrary.Levels
{
    /// <summary>
    /// intro to the experience
    /// </summary>
    public class Intro : Level
    {
        /// <summary>
        /// intro level
        /// </summary>
        public Intro()
        {
            TotalEnemies = 3;
            TotalSecrets = 1;
        }

        /// <summary>
        /// starts intro
        /// </summary>
        public override void Start(Player player)
        {
            Console.WriteLine("you are approaching a lonely house in the forest");

            player.Result = String.Empty;

            while (!I)
            {
                player.Auth = false;

                while (!player.Auth)
                {
                    if (player.Result.Contains("1") && player.Result.Contains("2"))
                    {
                        player.Auth = true;
                        I = true;

                        break;
                    }

                    Console.WriteLine("do you wanna enter the house or check the backyard");

                    player.Decision = Console.ReadLine();
                    Console.Clear();

                    switch (player.Decision)
                    {
                        case "house":
                            House(player);

                            break;

                        case "backyard":
                            Backyard(player);

                            break;

                        default:
                            Console.WriteLine("i didnt recognize that man");

                            break;
                    }
                }
            }

            player.Result = String.Empty;

            while (!II)
            {

            }    
        }

        /// <summary>
        /// house scenario of first third
        /// </summary>
        /// <param name="player"></param>
        public void House(Player player)
        {
            if (player.Result.Contains("1"))
            {
                Console.WriteLine($"{player.Name}, you already checked here dude!");

                return;
            }

            Console.WriteLine("you walk inside the decaying home and start looking around...");
            Console.ReadKey();

            Console.WriteLine("theres some codeine!");
            Console.ReadKey();
            Console.Clear();

            player.Inventory.Add(new Codeine());

            Console.WriteLine($"{player.Name}, type i to view your inventory!");
            player.Decision = Console.ReadLine();
            Console.Clear();

            player.Auth = false;

            while (!player.Auth)
            {
                switch (player.Decision)
                {
                    case "i":
                        Console.WriteLine($"{player.Inventory}");
                        Console.WriteLine("you can open and interact with your inventory at any point during a battle by typing i");
                        Console.ReadKey();
                        Console.Clear();

                        player.Auth = true;

                        break;

                    default:
                        Console.WriteLine("i didnt recognize that");
                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("type i to view your inventory dude");
                        player.Decision = Console.ReadLine();

                        break;
                }
            }

            Console.WriteLine("you continue to look through the house but nothing else draws your attention..");
            Console.ReadKey();
            Console.Clear();

            player.Result = player.Result + "1";
        }

        /// <summary>
        /// backayrd scenario of first third
        /// </summary>
        /// <param name="player"></param>
        public void Backyard(Player player)
        {
            if (player.Result.Contains("2"))
            {
                Console.WriteLine($"{player.Name}, you already checked here");

                return;
            }

            Console.WriteLine("you start looking around the backyard and find a rich tech guy! attack!");
            Console.ReadKey();
            Console.Clear();

            player.InitiateFight(new RichTechGuy());

            player.Result = player.Result + "2";
        }
    }
}