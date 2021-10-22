using System;
using System.Collections.Generic;

namespace Domain
{
    public class Game
    {

        public readonly List<int> _highscores = new ();
        public int Eye1 => _dice1.Dots;
        public int Eye2 => _dice2.Dots;

        private Dice _dice1;
        private Dice _dice2;

        public bool HasSnakeEyes => _dice1.Dots == 1 && _dice2.Dots == 1;
        public IReadOnlyList<int> HighScores => _highscores.AsReadOnly();
        public int Total { get; private set; }
        public Game()
        {
            Initialize();
         
        }

        public void Initialize()
        {
            _dice1 = new();
            _dice2 = new();
        }

        public void Play()
        {
            _dice1.Roll();
            _dice2.Roll();

            if (HasSnakeEyes)
            {
                _highscores.Add(Total);
                Total = 0;
            }
            else
            {
                Total += Eye1 + Eye2;
            }
        }

        public void Restart()
        {
            Initialize();
        }
    }
}
