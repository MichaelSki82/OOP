using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Random;

namespace SkipinGame
{
    public abstract class InteractiveObject : MonoBehaviour, IExecute
    {
        protected Color _color;

        private bool _isInteractable;

        public event System.Action MyAction;
        protected bool IsInteractable
        {
            get { return _isInteractable; }
            private set
            {
                _isInteractable = value;
                GetComponent<Renderer>().enabled = _isInteractable;
                GetComponent<Collider>().enabled = _isInteractable;

            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.GetComponent<SkipinGame.PlayerBall>() != null)
            {
                this.MyAction?.Invoke();
            }

            if (!IsInteractable || !other.gameObject.GetComponent<SkipinGame.PlayerBall>())
            {
                return;
            }
            Interaction();
            IsInteractable = false;
            //Destroy(gameObject);
        }

        protected abstract void Interaction();
        public abstract void Execute();


        private void Start()
        {
            IsInteractable = true;
            _color = ColorHSV();
            if (TryGetComponent(out Renderer renderer))
            {
                renderer.material.color = _color;
            }
            MyAction += Interaction;

        }

       /* public virtual void Interaction()
        {
            SomethingBaseMethod();
        }

        public void SomethingBaseMethod()
        {
            Debug.Log("Alloho Gawai");
        }*/





    }


}

