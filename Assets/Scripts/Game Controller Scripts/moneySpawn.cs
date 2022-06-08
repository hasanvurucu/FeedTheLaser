using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moneySpawn : MonoBehaviour
{
    public GameObject moneyPrefab;
    public Transform mainMovementTransform;
    public Transform actualSpawnPoint;
    private Vector3 mainMovementPOS;
    private int nextMoneyPos = 0;

    void Start()
    {
        mainMovementPOS = mainMovementTransform.position;
        nextMoneyPos -= Random.Range(2, 10);
    }
    
    void Update()
    {
        mainMovementPOS = mainMovementTransform.position;
        if (mainMovementPOS.z <= nextMoneyPos)
        {
            Instantiate(moneyPrefab, actualSpawnPoint.position, actualSpawnPoint.rotation);
            nextMoneyPos -= Random.Range(2, 10);
        }
    }
}
