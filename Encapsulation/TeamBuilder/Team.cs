using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TeamBuilder.Exceptions;

namespace TeamBuilder
{
    class Team
    {
        Checker checker = new Checker();

        private List<Player> players;

        private List<Player> Players
        {
            get { return players; }
            set { players = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set {
                checker.NameCheck(value);
                name = value; }
        }

        private int rating;

        public int Rating
        {
            get { return CalculateRating(); }
            set { rating = value; }
        }

        private int CalculateRating()
        {
            if (players.Count <= 0)
            {
                return 0;
            }
            int playerCount = players.Count;
            int playerAvg = players.Sum(x => x.Average);

            double result = playerAvg / playerCount;

            return (int)Math.Round(result);
        }

        public Team(List<Player> players, string name)
        {
            Players = players;
            Name = name;
        }


        public void AddPlayer(Player player)
        {
            this.Players.Add(player);
        }

        public void RemovePlayer(string playerName, Team team)
        {
            if (!team.players.Any(x => x.Name == playerName))
            {
                throw new ArgumentException($"Player {playerName} is not in {team.name} team.");
            }
            Player playerToRemove = team.players.Find(x => x.Name == playerName);
            team.players.Remove(playerToRemove);
        }
    }
}
