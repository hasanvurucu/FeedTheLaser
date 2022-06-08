using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cubePosChange : MonoBehaviour
{
    public int spawnPointZTemp;
    private int selectedLvl;
    Vector3 spawnHitPos;
    private Vector3 specialSpawnPointPOS;
    private int specialChance;

    public GameObject[] cubeLVLs;
    public GameObject spawnLvlhit;

    private int specialsRange; private bool specialSend = false;
    public GameObject maxPowerSpecial;
  //  public GameObject twentyPowerSpecial;
    public GameObject x2pointSpecial;
    public GameObject fullOfYellowsSpecial;
    //1 is max power, 2 is x2 point, 3 is x3 point
    //4 is fullOfYellows, 5 is give%20 of totalPower, 6 is surprise skin box
    public Transform specialSpawnPoint;

    public bool fullOfYellows;
    public float fullOfYellowsTimer =0f;

    public gameManager gameManagerScript;

    public Image fullOfYellowsImage;

    private void Start()
    {
        spawnPointZTemp = 0;

        selectedLvl = Random.Range(0, 7);
        Instantiate(cubeLVLs[selectedLvl], spawnLvlhit.transform.position, spawnLvlhit.transform.rotation);
        spawnPointZTemp -= 10;

        spawnHitPos = spawnLvlhit.transform.position;
        spawnHitPos.z = spawnPointZTemp;
        spawnLvlhit.transform.position = spawnHitPos;

        selectedLvl = Random.Range(0, 7);
        Instantiate(cubeLVLs[selectedLvl], spawnLvlhit.transform.position, spawnLvlhit.transform.rotation);
        spawnPointZTemp -= 10;

        spawnHitPos = spawnLvlhit.transform.position;
        spawnHitPos.z = spawnPointZTemp;
        spawnLvlhit.transform.position = spawnHitPos;
    }
    public void Update()
    {
        if(fullOfYellows == true)
        {
            fullOfYellowsImage.fillAmount = fullOfYellowsTimer / 8f;
            if (gameManagerScript.IsGamePaused != true)
            {
                fullOfYellowsTimer -= Time.deltaTime;
                if (fullOfYellowsTimer <= 0f)
                {
                    fullOfYellows = false;
                }
            }
        }else
        {
            fullOfYellowsImage.fillAmount = 0;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "cubePosChanger")
        {
            spawnPointZTemp -= 10;
            selectedLvl = Random.Range(0, 7);
            Instantiate(cubeLVLs[selectedLvl], spawnLvlhit.transform.position, spawnLvlhit.transform.rotation);
            spawnHitPos = spawnLvlhit.transform.position;
            spawnHitPos.z = spawnPointZTemp;
            spawnLvlhit.transform.position = spawnHitPos;

            specialChance = Random.Range(0, 100);
            if (specialChance <= 35)
            {
                specialSpawnPointPOS = specialSpawnPoint.position;
                specialSend = true;
                specialSpawnPointPOS.z -= 10;
                specialSpawnPoint.position = specialSpawnPointPOS;
            }
            else
            {
                specialSpawnPointPOS = specialSpawnPoint.position;
                specialSpawnPointPOS.z -= 10;
                specialSpawnPoint.position = specialSpawnPointPOS;
            }
        }
        if (specialSend == true)
        {
            specialsRange = Random.Range(0, 6);

               switch (specialsRange)
               {
                   case 0: break;
                   case 1: Instantiate(maxPowerSpecial, specialSpawnPoint.position, specialSpawnPoint.rotation); break;
                   case 2: Instantiate(x2pointSpecial, specialSpawnPoint.position, specialSpawnPoint.rotation); break;
             //      case 3: Instantiate(x3pointSpecial, specialSpawnPoint.position, specialSpawnPoint.rotation); break;
                   case 3: Instantiate(fullOfYellowsSpecial, specialSpawnPoint.position, specialSpawnPoint.rotation); break;
                //     case 4: Instantiate(twentyPowerSpecial, specialSpawnPoint.position, specialSpawnPoint.rotation); break;

                // case 6: surpriseSkinBox break;
                // case 7: killerBomb? break;

                default: break;

               }
               specialSend = false;
        }


    }

 
}
