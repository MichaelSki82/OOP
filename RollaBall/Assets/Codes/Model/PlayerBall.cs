using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkipinGame
{

    public sealed class PlayerBall : PlayerBase
    {
        private Rigidbody _rigidbody;
        //private Vector3 _movement;
       // private Quaternion _rotation = Quaternion.identity;

       // private bool _isGround;
        private void Start()
        {
           _rigidbody = GetComponent<Rigidbody>();
           Cursor.lockState = CursorLockMode.Locked;

        }
        public override void Move(float x, float y, float z)
        {
            _rigidbody.AddForce(new Vector3(x, y, z) * Speed);
        }
        
       /* public override void Jumping()
        {
            if (Input.GetAxis("Jump") > 0)
            {
                if (_isGround)
                {
                    _rigidbody.AddForce(Vector3.up * JumpSpeed);
                }
            }
        }
        
       /*private void OnCollisionEnter(Collision collision)
        {

            IsGroundedUpate(collision, true);

        }

        private void OnCollisionExit(Collision collision)
        {
            IsGroundedUpate(collision, false);
        }

        private void IsGroundedUpate(Collision collision, bool value)
        {
            if (collision.gameObject.tag == ("Ground"))
            {
                _isGround = value;
            }
        }
        /*private void FixedUpdate()
        {
            //Move();
            //Jumping();
        }*/
    }
}

