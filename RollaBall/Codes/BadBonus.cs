using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Random;
using System;

namespace SkipinGame
{
    public sealed class BadBonus : InteractiveObject, IFlay, IRotation
    {
        public event Action<string, Color> OnCaughtPlayerChange = delegate (string str, Color color) { };
        private float _lengthFlay;
        private float _speedRotation;

        private void Awake()
        {
            _lengthFlay = Range(1.0f, 5.0f);
            _speedRotation = Range(10.0f, 50.0f);
        }

        protected override void Interaction()
        {
            OnCaughtPlayerChange.Invoke(gameObject.name, _color);

            Destroy(gameObject);
        }

        public override void Execute()
        {
            if (!IsInteractable) { return; }
            Flay();
            Rotation();
        }

        public void Flay()
        {
            transform.localPosition = new Vector3(transform.localPosition.x,
                Mathf.PingPong(Time.time, _lengthFlay),
                transform.localPosition.z);
        }

        public void Rotation()
        {
            transform.Rotate(Vector3.up * (Time.deltaTime * _speedRotation), Space.World);
        }
    }
}

