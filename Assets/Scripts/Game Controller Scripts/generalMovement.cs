using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generalMovement : MonoBehaviour
{
    Vector3 pos;
    public float speed;
    public float speedTemp;
    public gameManager gameManagerScript;

    void Update()
    {
        if (gameManagerScript.IsGamePaused != true && gameManagerScript.IsGameStarted == true)
        {
            pos = transform.position;
            pos.z -= speed;
            if (speed <= 0.1)
            {
                speed += (Time.deltaTime) / 100;
            }
            else if (speed <= 0.125)
            {
                speed += (Time.deltaTime) / 400;
            }
            else if(speed <= 0.15)
            {
                speed += (Time.deltaTime) / 1000;
            }
            else if (speed <= 0.18)
            {
                speed += (Time.deltaTime) / 4000;
            }
            else if(speed <= 0.2)
            {
                speed += (Time.deltaTime) / 30000;
            }

            transform.position = pos;
        }

        
    }
}
