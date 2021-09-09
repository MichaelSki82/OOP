using UnityEngine;

namespace TestSkipin
{
    public sealed class ExampleDeconstruct
    {
        private sealed class Player
        {
            private int _maxHP;
            private int _currentHP;

            public Player()
            {
                _maxHP = 100;
                _currentHP = 42;
            }

            public void Deconstruct(out int currentHP, out int maxHP) =>
                (currentHP, maxHP) = (_currentHP, _maxHP);
        }

        public void Main()
        {
            Player player = new Player();
            (int currentHP, int maxHP) = player;

            Debug.Log($"{currentHP}/{maxHP}");
        }
    }
}

