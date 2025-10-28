using p4lmLibrary.Entities;
using p4lmLibrary.Levels;
using p4lmLibrary.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4lmLibrary.CurrentPlayer
{
    public class Player : Entity
    {
        private Weapon _currentWeapon;

        public Weapon CurrentWeapon
        {
            get => _currentWeapon;
            set => _currentWeapon = value;
        }

        private Level _currentLevel;

        public Level CurrentLevel
        {
            get => _currentLevel;
            set => _currentLevel = value;
        }

        private int _discoveredSecrets;

        public int DiscoveredSecrets
        {
            get => _discoveredSecrets;
            set => _discoveredSecrets = value;
        }

        private string _decision;

        public string Decision
        {
            get => _decision;
            set => _decision = value;
        }

        private bool _validResponse;

        public bool ValidResponse
        {
            get => _validResponse;
            set => _validResponse = value;
        }

        public Player()
        {
            CurrentHealth = 100;
            MaxHealth = 100;
            CurrentWeapon = new Fists();
            BaseDamage = CurrentWeapon.Damage;
            DamageDecorator = 10;
            DiscoveredSecrets = 0;
            Decision = String.Empty;
        }

        public string GetResponse(Player player, string decisionOne, string decisionTwo)
            => GetResponseInternal(player, decisionOne, decisionTwo);

        public string GetResponse(Player player, string decisionOne, string decisionTwo, string decisionThree)
            => GetResponseInternal(player, decisionOne, decisionTwo, decisionThree);

        public string GetResponse(Player player, string decisionOne, string decisionTwo, string decisionThree, string decisionFour)
            => GetResponseInternal(player, decisionOne, decisionTwo, decisionThree, decisionFour);

        private string GetResponseInternal(Player player, params string[] decisions)
        {
            player.Decision = String.Empty;
            player.ValidResponse = false;

            while (!player.ValidResponse)
            {
                Console.WriteLine("your options are:");
                Console.WriteLine(string.Join("    |    ", decisions));

                player.Decision = Console.ReadLine()?.Trim().ToLower();

                Console.Clear();

                foreach (var decision in decisions)
                {
                    string comparisonValue;

                    if (decision.Contains('*'))
                    {
                        int start = decision.IndexOf('*') + 1;
                        int end = decision.LastIndexOf('*');
                        comparisonValue = decision.Substring(start, end - start);
                    }
                    else
                    {
                        comparisonValue = decision;
                    }

                    if (player.Decision == comparisonValue.ToLower())
                    {
                        player.ValidResponse = true;

                        return player.Decision;
                    }
                }

                Console.WriteLine($"{player.Name}, thats an invalid response");
            }

            return player.Decision;
        }
    }
}