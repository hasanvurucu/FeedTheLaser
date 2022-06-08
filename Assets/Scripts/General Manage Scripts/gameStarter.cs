using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameStarter : MonoBehaviour
{
    private float timer = 0f;

    void Update()
    {
        int GL = 0;
        PlayerPrefs.SetInt("gameLoop", GL);
        timer += Time.deltaTime;
        if(timer >= 0.1f)
        {
            SceneManager.LoadScene("mainScene");
        }
    }
}
