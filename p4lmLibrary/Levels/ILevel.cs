using p4lmLibrary.CurrentPlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4lmLibrary.Levels
{
    public interface ILevel
    {
        int TotalEnemies { get; set; }
        int TotalSecrets { get; set; }
        bool PartOneCompleted { get; set; }
        bool PartTwoCompleted { get; set; }
        bool PartThreeCompleted { get; set; }
        bool ScenarioOneCompleted { get; set; }
        bool ScenarioTwoCompleted { get; set; }
        bool Verified { get; set; }
        void Start(Player player);
        bool Verify(Player player);
        void PartOne(Player player);
        void PartTwo(Player player);
        void PartThree(Player player);
    }
}