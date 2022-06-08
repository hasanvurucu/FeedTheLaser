using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyMoneyIfBadPosition : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "maxPowerSpecial" || other.tag == "20PowerSpecial" || other.tag == "x2pointSpecial" || other.tag == "x3pointSpecial" || other.tag == "fullOfYellows")
        {
            Destroy(this.gameObject);
            Debug.Log("bad positioned money destroyed");
        }
    }
}
