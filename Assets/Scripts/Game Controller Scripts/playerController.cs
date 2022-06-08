using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    Vector3 laserPos;
    public GameObject laserObj;
    public GameObject collisionObj;

    public GameObject trailPrefab;
    public Transform trailPosReference;

    public Transform mainMovementTransform;

    public gameManager gameManagerScript;
    public laserHit laserHitScript;

    public generalMovement generalMovementScript;

    public ParticleSystem hitParticles;

    public bool laserOn;


    void Start()
    {
        var em = hitParticles.emission;
        em.enabled = false;

        laserPos = laserObj.transform.position;
        laserPos.z = 5f;
        laserObj.transform.position = laserPos;
        collisionObj.SetActive(false);
    }

    void Update()
    {
        transform.Rotate(0, -Time.deltaTime * 180, 0);

        transform.localScale = new Vector3(gameManagerScript.power, gameManagerScript.power, gameManagerScript.power);

        laserPos = laserObj.transform.position;

        if (gameManagerScript.death == true)
        {
            gameObject.GetComponent<Renderer>().enabled = false;
            laserObj.GetComponent<Renderer>().enabled = false;
            generalMovementScript.speed = 0;
        }

        if (gameManagerScript.IsGamePaused != true && gameManagerScript.IsGameStarted == true && gameManagerScript.death != true)
        {
            if (Input.GetMouseButton(0) || Input.GetMouseButtonDown(0))
            {
                laserPos.z = transform.position.z;
                laserObj.transform.position = laserPos;
                laserOn = true;
                collisionObj.SetActive(true);

                var em = hitParticles.emission;
                em.enabled = true;
            }
            else
            {
                laserPos.z = 5f;
                laserObj.transform.position = laserPos;
                laserOn = false;
                collisionObj.SetActive(false);
                laserHitScript.hitSituation = 0;

                var em = hitParticles.emission;
                em.enabled = false;
            }
            if (gameManagerScript.death != true)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    Instantiate(trailPrefab, trailPosReference.position, trailPosReference.rotation);
                }
            }
        }
        
    }
}
