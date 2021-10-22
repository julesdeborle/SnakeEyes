using System;

namespace Domain
{
    internal class Dice
    {
        public int Dots { get; set; }

        private static Random _randomizer = new();

        public Dice()
        {
            Dots = 6;
        }

        public void Roll()
        {
            Dots = _randomizer.Next(1, 7);
        }
    }
}
