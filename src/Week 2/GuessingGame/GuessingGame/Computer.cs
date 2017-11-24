using System;

namespace GuessingGame
{
    public static class Computer
    {
        private static Random random = new Random();

        public static int ThinkOfNumber()
        {
            return random.Next(1, 101);
        }
    }
}