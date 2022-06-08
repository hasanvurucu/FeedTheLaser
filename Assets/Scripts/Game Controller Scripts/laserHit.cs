using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserHit : MonoBehaviour
{
    public int hitSituation; //0 -> Nothing | 1 -> black | 2 -> yellow || 3-> red
    public playerController playerControllerScript;
    public gameManager gameManagerScript;
    public cubePosChange cubePosChangeScript;
    public soundManager soundManagerScript;

    private int moneyReference;
    public GameObject moneyTextObj;
    public GameObject fullHpTextObj;
    public GameObject x2pointsTextObj;

    public ParticleSystem hitParticles;
    public Material[] materialsForHit;

    void Start()
    {
        hitSituation = 0;
        moneyReference = PlayerPrefs.GetInt("money");

        soundManagerScript.closePointsSound();
    }
    
    void Update()
    {
        if(playerControllerScript.laserOn == false)
        {
            hitSituation = 0;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (gameManagerScript.death == false)
        {
            if (other.tag == "red")
            {
                if (playerControllerScript.laserOn == true)
                {
                    hitSituation = 3; //die
                    hitParticles.GetComponent<Renderer>().material = materialsForHit[2];
                }
            }
            if (other.tag == "black")
            {
                if (playerControllerScript.laserOn == true)
                {
                    hitSituation = 1; //lose power
                    hitParticles.GetComponent<Renderer>().material = materialsForHit[1];

                    soundManagerScript.openFalseHitSound(); //false hit sound plays
                    soundManagerScript.closePointsSound();
                }
            }
            if (other.tag == "yellow")
            {
                if (playerControllerScript.laserOn == true)
                {
                    hitSituation = 2; //gain power and points
                    hitParticles.GetComponent<Renderer>().material = materialsForHit[0];

                    soundManagerScript.openPointsSound(); //point collect sound plays
                    soundManagerScript.closeFalseHitSound();
                }
            }

            if (other.tag == "maxPowerSpecial")
            {
                //maximize power
                gameManagerScript.power = 1f;
                fullHpTextObj.SetActive(false);
                fullHpTextObj.SetActive(true);
                Destroy(other.gameObject);

                soundManagerScript.specialsCollectSound();
            }
       /*     if (other.tag == "20PowerSpecial")
            {
                //add %50 of total power
                gameManagerScript.power += 0.5f;
                Destroy(other.gameObject);
            } */
            if(other.tag == "x2pointSpecial")
            {
                Debug.Log("x2points now");
                gameManagerScript.pointMultiplier = 2;
                x2pointsTextObj.SetActive(false);
                x2pointsTextObj.SetActive(true);
                Destroy(other.gameObject);

                soundManagerScript.specialsCollectSound();
            }
       /*     if(other.tag == "x3pointSpecial")
            {
                Debug.Log("x3points now");
                gameManagerScript.pointMultiplier = 3;
                Destroy(other.gameObject);
            }*/
            if(other.tag == "fullOfYellows")
            {
                Debug.Log("full of yellows for 8 seconds");
                cubePosChangeScript.fullOfYellows = true;
                cubePosChangeScript.fullOfYellowsTimer = 8f;
                Destroy(other.gameObject);

                soundManagerScript.specialsCollectSound();
            }

            if(other.tag == "money")
            {
                moneyReference++;
                Debug.Log("moneyTaken. Money is: "+ moneyReference);
                PlayerPrefs.SetInt("money", moneyReference);
                moneyTextObj.SetActive(false);
                moneyTextObj.SetActive(true);
                Destroy(other.gameObject);

                soundManagerScript.moneyCollSound();
            }
        }
    }
}
