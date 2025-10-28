using p4lmLibrary.CurrentPlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4lmLibrary.Levels
{
    public class InfoGather : Level
    {
        public InfoGather(Player player)
        {
            TotalEnemies = 0;
            TotalSecrets = 1;

            PartOneCompleted = false;
            PartTwoCompleted = false;
            PartThreeCompleted = false;
        }

        public override void Start(Player player)
        {
            Console.WriteLine("oh hello there, what is your name?");
            player.Name = Console.ReadLine();
            Console.Clear();

            Console.WriteLine($"{player.Name}... i like it!");
            Console.ReadKey();

            player.Decision = player.GetResponse(player, "begin", "info", "exit");
            Console.Clear();

            switch (player.Decision)
            {
                case "begin":
                    Console.WriteLine($"perfect! lets go wandering in the forest {player.Name}...");
                    Console.ReadKey();
                    Console.Clear();

                    break;

                case "info":
                    Console.WriteLine("you really want more info??");

                    player.Decision = player.GetResponse(player, "yes", "no");
                    Console.Clear();

                    switch (player.Decision)
                    {
                        case "yes":
                            Console.WriteLine("well, this is a console text game! there are alot of secrets and features, so be vigilant!");
                            Console.WriteLine($"speaking of which {player.Name}... not many people actually read these things. you are one of the select few.");
                            Console.ReadKey();
                            Console.WriteLine("heres a secret point, there are 6 more. lets start the experience now...");
                            Console.ReadKey();

                            break;

                        case "no":
                            Console.WriteLine($"you teasebox, come on lets start the experience instead...");
                            Console.ReadKey();

                            break;
                    }

                    break;

                case "exit":
                    Console.WriteLine($"you know {player.Name}, thats respectable");
                    Environment.Exit(0);

                    break;
            }

            Console.Clear();

            player.CurrentLevel.PartOneCompleted = true;
            player.CurrentLevel.PartTwoCompleted = true;
            player.CurrentLevel.PartThreeCompleted = true;

            player.CurrentLevel.Verify(player);
        }
    }
}