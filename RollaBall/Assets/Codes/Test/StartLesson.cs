using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TestSkipin
{

    internal class StartLesson : MonoBehaviour
    {
        
        void Start()
        {
            new ExampleChecked().Main();
            new ExampleTuple().Main();
            new ExampleDeconstruct().Main();
        }

       
    }
}
