using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkipinGame
{


    public abstract class PlayerBase: MonoBehaviour
    {
        public float Speed = 3.0f;
        public float JumpSpeed  = 125.0f;
        

        
       

        public abstract void Move(float x, float y, float z);
        
        


       


      /* protected void Jumping()
        {
            if (Input.GetAxis("Jump") > 0)
            {
                if (_isGround)
                {
                    _rigidbody.AddForce(Vector3.up * JumpSpeed);
                }
            }
        }*/

        
        
    }
}
