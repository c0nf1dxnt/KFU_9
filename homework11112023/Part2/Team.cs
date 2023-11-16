using System;
using System.Collections.Generic;

namespace Part2
{
    class Team
    {
        private string name;
        private List<IGame> games;

        public Team(string Name)
        {
            name = Name;
            games = new List<IGame>();
        }

        public void AddGame(IGame Game)
        {
            games.Add(Game);
        }
        public void PlayGames()
        {
            Console.WriteLine($"Команда {name} играет в следующие игры:");
            foreach (var game in games)
            {
                game.Play();
            }
        }
    }
}
