using System;
using System.Collections.Generic;
using System.Text;

namespace Refresher_ExplodingKittens
{
    class GameManager
    {
        private Random random = new Random();
        private Player[] players = new Player[5];
        private Deck deck;

        public void Setup()
        {


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
                    Console.Write(list[x] + " ");
            else
                for (int x = list.Count-1; x >= 0; x--)
                    Console.Write(list[x] + " ");
        }
    }
}
