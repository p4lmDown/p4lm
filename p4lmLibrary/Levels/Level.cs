using p4lmLibrary.CurrentPlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4lmLibrary.Levels
{
    public class Level : ILevel
    {
        private int _totalEnemies;

        public int TotalEnemies
        {
            get => _totalEnemies;
            set => _totalEnemies = value;
        }

        private int _totalSecrets;

        public int TotalSecrets
        {
            get => _totalSecrets;
            set => _totalSecrets = value;
        }

        private bool _partOneCompleted;

        public bool PartOneCompleted
        {
            get => _partOneCompleted;
            set => _partOneCompleted = value;
        }

        private bool _partTwoCompleted;

        public bool PartTwoCompleted
        {
            get => _partTwoCompleted;
            set => _partTwoCompleted = value;
        }

        private bool _partThreeCompleted;

        public bool PartThreeCompleted
        {
            get => _partThreeCompleted;
            set => _partThreeCompleted = value;
        }

        private bool _scenarioOneCompleted;

        public bool ScenarioOneCompleted
        {
            get => _scenarioOneCompleted;
            set => _scenarioOneCompleted = value;
        }

        private bool _scenarioTwoCompleted;

        public bool ScenarioTwoCompleted
        {
            get => _scenarioTwoCompleted;
            set => _scenarioTwoCompleted = value;
        }

        private bool _verified;

        public bool Verified
        {
            get => _verified;
            set => _verified = value;
        }

        public virtual void Start(Player player)
        {
            // Starts the level (sets the scene, etc etc)
        }

        public bool Verify(Player player)
        {
            if (player.CurrentLevel.PartOneCompleted && player.CurrentLevel.PartTwoCompleted || player.CurrentLevel.PartThreeCompleted)
            {
                player.CurrentLevel.Verified = true;
            }
            else
            {
                Console.WriteLine("you have to complete all parts of the level!");
            }

            return player.CurrentLevel.Verified;
        }

        public virtual void PartOne(Player player)
        {
            // Part one of the level
        }

        public virtual void PartTwo(Player player)
        {
            // Part two of the level
        }

        public virtual void PartThree(Player player)
        {
            // Part three of the level
        }
    }
}