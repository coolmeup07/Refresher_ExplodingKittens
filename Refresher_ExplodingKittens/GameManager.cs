using System;
using System.Collections.Generic;
using System.Text;

namespace Refresher_ExplodingKittens
{
    class GameManager
    {
        private Random random = new Random();
        private Player[] players = new Player[4];
        private Deck deck;

        public void SetupGame()
        {
            // Get Player Name
            Console.Write("Please type your name: ");
            players[0] = new HumanPlayer(Convert.ToString(Console.ReadLine()));
            Console.WriteLine("Welcome " +players[0].PlayerName);

            // Create AI Players
            for (int x = 0; x < 3; x++)
                players[x + 1] = new AIPlayer("AI " +(x+1));

            Console.WriteLine("Current Players:");
            for (int x = 0; x < players.Length; x++)
                Console.WriteLine(players[x].PlayerName);

            //Initialize Deck
            deck = new Deck(this);
            deck.CompleteDeck(players.Length);
            deck.ShuffleCards();
            deck.DisplayCards();

            while (players[0].IsAlive)
            {
                deck.DrawCard().DisplayCard();
                Console.WriteLine("Current Deck.");
                deck.DisplayCards();
                Console.ReadLine();
            }
        }

        public void GameLoop()
        {

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
