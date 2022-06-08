using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateCoinAndHeart : MonoBehaviour
{
    void Start()
    {
        transform.Rotate(-90f, 0, 0);
    }

    private void Update()
    {
        transform.Rotate(0, 0, -Time.deltaTime*180);
    }
}
