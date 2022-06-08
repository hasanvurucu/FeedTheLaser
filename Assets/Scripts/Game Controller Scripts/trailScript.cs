using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trailScript : MonoBehaviour
{
    private bool IsReleased = false;
    private float timer = 0f;
    public GameObject trailPosReference;

    void Start()
    {
        transform.Rotate(new Vector3(-90, 0, 0));
        trailPosReference = GameObject.FindGameObjectWithTag("trailPos");
    }

    void Update()
    {
        if(IsReleased != true)
        {
            Vector3 pos = trailPosReference.transform.position;
            transform.position = pos;
        }

        if(Input.GetMouseButtonUp(0))
        {
            IsReleased = true;
        }
        if(IsReleased == true)
        {
            timer += Time.deltaTime;
        }
        if(timer >= 2f)
        {
            Destroy(this.gameObject);
        }
    }
}
