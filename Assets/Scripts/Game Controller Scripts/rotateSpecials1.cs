using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateSpecials1 : MonoBehaviour
{
   // private float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
       // timer += Time.deltaTime;
     /*   if(timer < 0.5f)
        {
            transform.Rotate(0, -Time.deltaTime * 180, 0);
            
        }else if(timer < 1)
        { */
            transform.Rotate(0, -Time.deltaTime * 180, 0);
     /*   }else
        {
            timer = 0;
        }
        */
    }
}
