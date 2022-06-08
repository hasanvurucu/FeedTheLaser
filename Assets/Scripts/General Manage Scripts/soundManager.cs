using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundManager : MonoBehaviour
{
    public playerController playerControllerScript;

    public GameObject clickSound;
    public GameObject dieSound;
    public GameObject falseHitSound;
    public GameObject levelUpSound;
    public GameObject pointSound;
    public GameObject specialCollectSound;
    public GameObject moneyCollectSound;

    private void Update()
    {
        gameManager gameManagerScript = GetComponent<gameManager>();

        if(playerControllerScript.laserOn != true || gameManagerScript.death == true)
        {
            closePointsSound();
            closeFalseHitSound();
        }
    }

    public void playClickSound()
    {
        clickSound.SetActive(false);
        clickSound.SetActive(true);
    }

    public void openDieSound()
    {
        dieSound.SetActive(true);
    }
    public void closeDieSound()
    {
        dieSound.SetActive(false);
    }
    
    public void openPointsSound()
    {
        pointSound.SetActive(true);
    }
    public void closePointsSound()
    {
        pointSound.SetActive(false);
    }

    public void openFalseHitSound()
    {
        falseHitSound.SetActive(true);
    }
    public void closeFalseHitSound()
    {
        falseHitSound.SetActive(false);
    }

    public void specialsCollectSound()
    {
        specialCollectSound.SetActive(false);
        specialCollectSound.SetActive(true);
    }

    public void moneyCollSound()
    {
        moneyCollectSound.SetActive(false);
        moneyCollectSound.SetActive(true);
    }

    public void lvlUpSound()
    {
        levelUpSound.SetActive(false);
        levelUpSound.SetActive(true);
    }


    // public void 
}
