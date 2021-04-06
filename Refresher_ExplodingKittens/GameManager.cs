using System;
using System.Collections.Generic;
using System.Text;

namespace Refresher_ExplodingKittens
{
    class GameManager
    {
        private Random random = new Random();
        private List<Player> players = new List<Player>();
        private Deck deck;
        private int currentTurn;
        private int turns;

        public void SetupGame()
        {
            // Get Player Name
            Console.Write("Please type your name: ");
            players.Add(new HumanPlayer(Convert.ToString(Console.ReadLine())));
            Console.WriteLine("Welcome " +players[0].PlayerName);

            // Create AI Players
            for (int x = 0; x < 3; x++)
                players.Add(new AIPlayer("AI " +(x+1)));

            Console.WriteLine("Current Players:");
            for (int x = 0; x < players.Count; x++)
                Console.WriteLine(players[x].PlayerName);

            // Shuffle Player Order
            Console.WriteLine("Shuffling Player turn order");
            ShuffleList(players);

            //Initialize Deck
            deck = new Deck(this);
            deck.CompleteDeck(players.Count);
            deck.ShuffleCards();

            while (MoreThan1PlayerAlive())
            {
                GameLoop();
            }
        }

        public void GameLoop()
        {
            for (int x = 0; x < players.Count; x++)
            {
                DisplayTurnOrder();
                players[x].EvaluateTurn();

                Console.WriteLine("Enter to begin next turn");
                Console.ReadLine();
                currentTurn++;
                turns++;
                if (x == players.Count - 1) currentTurn = 0;
            }
        }

        public void DisplayTurnOrder()
        {
            Console.WriteLine("Current Turn: {0}", turns);
            for(int x=0; x<players.Count; x++)
            {
                if (x == currentTurn)
                    Console.WriteLine("{0} <--- Current Player", players[x].PlayerName);
                else
                    Console.WriteLine("{0}", players[x].PlayerName);
            }
        }

        public bool MoreThan1PlayerAlive()
        {
            int aliveCounter = 0;
            for (int x=0; x<players.Count; x++)
            {
                if (players[x].IsAlive)
                    aliveCounter += 1;
            }
            return (aliveCounter > 1);
        }

        public int GetRandomNum(int min, int max){ return random.Next(min, max); }
        public void ShuffleList<T>(List<T> list)
        {
            for(int x = list.Count-1; x > 0; x--)
            {
                var temp = list[x];
                int idx = random.Next(0, x);

                // Swapping
                list[x] = list[idx];
                list[idx] = temp;
            }
        }
        public void ReverseList<T>(List<T> list)
        {
            for (int x = 0; x < list.Count/2; x++)
            {
                var temp = list[x];
                list[x] = list[list.Count-1-x];
                list[list.Count-1-x] = temp;
            }
        }
        public void DisplayList<T>(List<T> list, bool reverse)
        {
            if (!reverse)
                for (int x = 0; x < list.Count; x++)
                    Console.WriteLine(list[x] + " ");
            else
                for (int x = list.Count-1; x >= 0; x--)
                    Console.WriteLine(list[x] + " ");
        }
    }
}
