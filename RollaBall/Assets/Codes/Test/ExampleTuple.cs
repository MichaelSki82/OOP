using UnityEngine;

namespace TestSkipin
{
    public sealed class ExampleTuple
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

            public (int currentHP, int maxHP) GetHP()
            {
                return (_currentHP, _maxHP);
            }
        }

        public void Main()
        {
            Player player = new Player();
            (int currentHP, int maxHP) playerHp = player.GetHP();

            Debug.Log($"{playerHp.currentHP}/{playerHp.maxHP}");
        }
    }
}