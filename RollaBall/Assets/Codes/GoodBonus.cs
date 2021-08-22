using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Random;
using System;

namespace SkipinGame
{
    public sealed class GoodBonus : InteractiveObject, IFlay, IFlicker
    {
        public int Point;
        public event Action<int> OnPointChange = delegate (int i) { };
        private Material _material;
        private float _lengthFlay;
        private DisplayBonuses _displayBonuses;

        private void Awake()
        {
            _material = GetComponent<Renderer>().material;
            _lengthFlay = Range(1.0f, 5.0f);
            MyAction += Flicker;
            MyAction += Flay;
            _displayBonuses = new DisplayBonuses();

        }
        protected override void Interaction()
        {
            OnPointChange.Invoke(Point);
        }

        public override void Execute()
        {
            if (!IsInteractable) { return; }
            Flay();
            Flicker();
            /*_displayBonuses.Display(5);
            base.Interaction();
            Debug.Log("I contact with Good");*/
        }

        public void Flay()
        {
            transform.localPosition = new Vector3(transform.localPosition.x, 
                Mathf.PingPong(Time.time, _lengthFlay), transform.localPosition.z); ;
        }

        public void Flicker()
        {
            _material.color = new Color(_material.color.r, _material.color.g, _material.color.b, Mathf.PingPong(Time.time, 1.0f));
        }
    }

}

