using System;
using UnityEngine;

namespace TestSkipin

{
    public sealed class ExampleChecked
    {
        public void Main()
        {
            int a = 150;
            int b = 150;

            try
            {
                byte result = checked((byte)(a + b));
            }
            catch (Exception e)
            {
                Debug.Log(e.Message);
            }
        }
    }
}

