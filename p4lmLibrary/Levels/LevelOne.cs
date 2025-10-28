using p4lmLibrary.CurrentPlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4lmLibrary.Levels
{
    public class LevelOne : Level
    {
        public LevelOne(Player player)
        {
            TotalEnemies = 3;
            TotalSecrets = 1;

            PartOneCompleted = false;
            PartTwoCompleted = false;
            PartThreeCompleted = false;
            ScenarioOneCompleted = false;
            ScenarioTwoCompleted = false;
        }

        public override void Start(Player player)
        {
            Console.Clear();
            Console.WriteLine("you approach a lonely house in the middle of the forest");

            PartOne(player);
            PartTwo(player);
            PartThree(player);
        }

        public override void PartOne(Player player)
        {
            while (!player.CurrentLevel.PartOneCompleted)
            {
                player.Decision = player.GetResponse(player, "enter the *house*", "look through the *forest*");
                Console.Clear();

                switch (player.Decision)
                {
                    case "house":

                        if (ScenarioOneCompleted)
                        {
                            Console.WriteLine($"{player.Name}, you already did this part!");
                            Console.ReadKey();
                            Console.Clear();

                            break;
                        }

                        Console.WriteLine("you approach the decaying house and head inside through the front door");
                        Console.ReadKey();
                        Console.Clear();

                        player.Decision = player.GetResponse(player, "enter the *bedroom*", "check the *living room*");

                        switch (player.Decision)
                        {
                            case "bedroom":

                                Console.WriteLine("you enter the bedroom and see an almost empty codeine bottle!");

                                break;

                            case "living room":



                                break;
                        }

                        break;

                    case "forest":

                        if (ScenarioTwoCompleted)
                        {
                            Console.WriteLine($"{player.Name}, you already did this part!");
                            Console.ReadKey();
                            Console.Clear();

                            break;
                        }

                        break;
                }
            }
        }

        public override void PartTwo(Player player)
        {

        }

        public override void PartThree(Player player)
        {

        }
    }
}