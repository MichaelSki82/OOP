using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SkipinGame
{
    public sealed class DisplayBonuses
    {
        private Text _text;
        public DisplayBonuses()
        {
            //_text = Object.FindObjectOfType<Text>();
        }

        public void Display(int value)
        {
            
            _text.text = $"�� ������� {value}";
        }
    }

}

