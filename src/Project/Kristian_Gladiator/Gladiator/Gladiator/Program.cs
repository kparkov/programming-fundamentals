using System;
using System.Reflection;

namespace Gladiator
{
    class Program
    {
        static void Main(string[] args)
        {
            var gameController = new GameController();
            gameController.RunGame();
            
            Console.ReadKey();
        }
    }
}
