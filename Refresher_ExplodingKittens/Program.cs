using System;

namespace Refresher_ExplodingKittens
{
    class Program
    {
        static void Main(string[] args)
        {
            GameManager gm = new GameManager();
            gm.SetupGame();
            gm.GameLoop();
            Console.WriteLine();
        }
    }
}
