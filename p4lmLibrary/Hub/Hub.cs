using p4lmLibrary.CurrentPlayer;
using p4lmLibrary.Levels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4lmLibrary.Hub
{
    public class Hub
    {
        public void Engage()
        {
            Player player = new Player();

            player.CurrentLevel = new InfoGather(player);
            player.CurrentLevel.Start(player);

            Console.WriteLine("pro tip... the words wrapped in asterisks (*) are the navigation words. use those when typing your responses.");
            Console.WriteLine("ex. open the *door*");
            Console.ReadKey();
            Console.Clear();

            player.CurrentLevel = new LevelOne(player);
            player.CurrentLevel.Start(player);
        }
    }
}