using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialManager : MonoBehaviour
{
    private int tutorialDone;

    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;

    private float timer;

    private gameManager gameManagerScript;

    public bool gameIsStarted;

    private void Awake()
    {
        gameManagerScript = GetComponent<gameManager>();
    }

    void Start()
    {
        timer = 0f;
        panel1.SetActive(false);
        panel2.SetActive(false);
        panel3.SetActive(false);
        tutorialDone = PlayerPrefs.GetInt("tutorialDone");
        PlayerPrefs.SetInt("tutorialDone", tutorialDone);
    }
    
    void Update()
    {
        if(tutorialDone == 0)
        {
            if(gameIsStarted == true)
            {
                if (timer <= 0.1f)
                {
                    timer += Time.deltaTime;
                }
                else if(timer >= 0.1f && timer <= 5f)
                {
                    gameManagerScript.pauseGame();
                    gameManagerScript.tapToResumePanel.SetActive(false);
                    panel1.SetActive(true);
                    timer = 10f;
                }
            }
        }
    }

    public void goPanel2()
    {
        panel1.SetActive(false);
        panel2.SetActive(true);
    }
    public void goPanel3()
    {
        panel2.SetActive(false);
        panel3.SetActive(true);
    }
    public void endTutorial()
    {
        panel3.SetActive(false);
        tutorialDone = 1;
        PlayerPrefs.SetInt("tutorialDone", tutorialDone);
        gameManagerScript.tapToResumePanel.SetActive(true);
    }
}
