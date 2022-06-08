using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelXPManager : MonoBehaviour
{
    public int level; //playerprefs... //static

    public GameObject lvlUpText;

    public bool levelUpMoment = false;

    public float requiredXP;
    public float remainingXP;
    public float tempScore;

    public Text levelText;
    public gameManager gameManagerScript;

    void Start()
    {
        level = PlayerPrefs.GetInt("level");

        if(level == 0)
        {
            level = 1;
        }

        remainingXP = 0f;
        tempScore = 0f;

        requiredXP = ((level * 250) * ((float)level / 10)) + 600;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt("level", level);

        xpAndLevelCheck();
        setTextMethod();

        if(levelUpMoment == true)
        {
            levelUpMethod();
            levelUpMoment = false;
        }
    }

    void xpAndLevelCheck()
    {
        if (gameManagerScript.death != true)
        {
            remainingXP = gameManagerScript.score - tempScore;
        }
        if (levelUpMoment == false)
        {
            if (remainingXP >= requiredXP)
            {
                levelUpMoment = true;
                tempScore += remainingXP;
                remainingXP = 0f;
            }
        }
    }

    public void setTextMethod()
    {
        levelText.text = level.ToString();
    }

    public void levelUpMethod()
    {
        level += 1;
        requiredXP = ((level * 250) * ((float)level / 10)) + 600;

        lvlUpText.SetActive(false);
        lvlUpText.SetActive(true);

        soundManager soundManagerScript = GetComponent<soundManager>();
        soundManagerScript.lvlUpSound();
    }


}
