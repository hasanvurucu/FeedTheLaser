using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeIdentitySet : MonoBehaviour
{
    public cubePosChange cubePosChangeScript;
    public Material[] colors;
    private string originalTag;

    // Start is called before the first frame update
    private void Awake()
    {
        originalTag = this.gameObject.tag;
        colors[1] = GetComponent<Renderer>().material;
        cubePosChangeScript = GameObject.FindGameObjectWithTag("player").GetComponent<cubePosChange>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(cubePosChangeScript.fullOfYellows == true)
        {
            this.gameObject.tag = "yellow";
        }

        if(cubePosChangeScript.fullOfYellows == false)
        {
            this.gameObject.tag = originalTag;
            GetComponent<Renderer>().material = colors[1];
        }

        if(originalTag == "yellow")
        {

        }
        else if(this.gameObject.tag == "yellow")
        {
            GetComponent<Renderer>().material = colors[0];
        }
    }
}
