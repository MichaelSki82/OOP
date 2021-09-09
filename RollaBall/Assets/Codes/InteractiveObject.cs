using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Random;

namespace SkipinGame
{
    public abstract class InteractiveObject : MonoBehaviour, IExecute
    {
        [SerializeField] private bool _isAllowScaling;
        [SerializeField] private float _activeDis;
        
        protected Color _color;

        private bool _isInteractable;

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
            if (!IsInteractable || !other.CompareTag("Player"))
            {
                return;
            }
            IsInteractable = false;
            Interaction();
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
        }

        private void OnDrawGizmos()
        {
            Gizmos.DrawIcon(transform.position, "Face.jpg", _isAllowScaling);
        }

        private void OnDrawGizmosSelected()
        {
#if UNITY_EDITOR
            Transform t = transform;

            var flat = new Vector3(_activeDis, 0, _activeDis);
            Gizmos.matrix = Matrix4x4.TRS(t.position, t.rotation, flat);
            Gizmos.DrawWireSphere(Vector3.zero, 5);
#endif
        }
    }


}

