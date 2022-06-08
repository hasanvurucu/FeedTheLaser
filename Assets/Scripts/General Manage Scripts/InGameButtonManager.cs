using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InGameButtonManager : MonoBehaviour
{
    public Highscores highscoresScript;

    public GameObject highscoreManagementObj;

    public GameObject leaderboardObj;
    public GameObject shopObj;
    public GameObject OptionsObj;
    public GameObject openLBbutton;
    public GameObject openSHOPbutton;
    public GameObject openOPTSbutton;

    public GameObject openLBbutton2;
    public GameObject openSHOPbutton2;
    public GameObject openOPTSbutton2;
    public GameObject startGameButton;

    public GameObject fadeInPanel;
    float sceneFadeStart = 0f;
    bool isFadeStarted = false;

    public string whereIam;
    private gameManager gameManagerScript;
    private soundManager soundManagerScript;

    public bool videoWatch;

    public GameObject SOUNDS;
    public Camera mainCamera;
    public GameObject[] audioButtons;
    public bool isSoundMuted = false;

    private void Start()
    {
        gameManagerScript = GetComponent<gameManager>();
        soundManagerScript = GetComponent<soundManager>();

        if (PlayerPrefs.GetInt("gameLoop") == 0)
        {
            whereIam = "startMenu";
        }
        else
        {
            whereIam = "InGame";
        }

        if(isSoundMuted == true)
        {
            AudioListener AL = mainCamera.GetComponent<AudioListener>();
            AL.enabled = false;
            audioButtons[1].SetActive(true);
            audioButtons[0].SetActive(false);
        }else
        {
            AudioListener AL = mainCamera.GetComponent<AudioListener>();
            AL.enabled = true;
            audioButtons[0].SetActive(true);
            audioButtons[1].SetActive(false);
        }
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (whereIam == "leaderboard")
            {
                closeLeaderboard();
            }
            else if(whereIam == "options")
            {
                closeOptions();
            }
            else if(whereIam == "shop")
            {
                closeShop();
            }
            else if(whereIam == "InGame")
            {
                if (gameManagerScript.death != true)
                {
                    gameManagerScript.pauseGame();
                }
            }
        }

        if(isFadeStarted == true)
        {
            sceneFadeStart += Time.deltaTime;
            fadeInPanel.SetActive(true);
        }
        if(sceneFadeStart>= 0.52f)
        {
            SceneManager.LoadScene("mainScene");
        }
    }

    public void restartGameMethod()
    {
        Time.timeScale = 1;
        int GL = 1;
        PlayerPrefs.SetInt("gameLoop", GL);
        //SceneManager.LoadScene("mainScene");
        isFadeStarted = true;
        soundManagerScript.playClickSound();
    }

    public void openLeaderboard()
    {
        highscoreManagementObj.SetActive(false);
        highscoreManagementObj.SetActive(true);

        highscoresScript.callForUpload();

        leaderboardObj.SetActive(true);

        openLBbutton.SetActive(false);
        openSHOPbutton.SetActive(false);
        openOPTSbutton.SetActive(false);

        openLBbutton2.SetActive(false);
        openSHOPbutton2.SetActive(false);
        openOPTSbutton2.SetActive(false);
        startGameButton.SetActive(false);

        whereIam = "leaderboard";

        soundManagerScript.playClickSound();
    }
    public void closeLeaderboard()
    {
        leaderboardObj.SetActive(false);
        highscoreManagementObj.SetActive(false);
        openLBbutton.SetActive(true);
        openSHOPbutton.SetActive(true);
        openOPTSbutton.SetActive(true);

        openSHOPbutton2.SetActive(true);
        openLBbutton2.SetActive(true);
        openOPTSbutton2.SetActive(true);
        startGameButton.SetActive(true);

        whereIam = "endGameMenu";

        soundManagerScript.playClickSound();
    }

    public void openShop()
    {
        shopObj.SetActive(true);
        openSHOPbutton.SetActive(false);
        openLBbutton.SetActive(false);
        openOPTSbutton.SetActive(false);

        openLBbutton2.SetActive(false);
        openSHOPbutton2.SetActive(false);
        openOPTSbutton2.SetActive(false);
        startGameButton.SetActive(false);

        whereIam = "shop";

        soundManagerScript.playClickSound();
    }
    public void closeShop()
    {
        shopObj.SetActive(false);
        openSHOPbutton.SetActive(true);
        openLBbutton.SetActive(true);
        openOPTSbutton.SetActive(true);

        openSHOPbutton2.SetActive(true);
        openLBbutton2.SetActive(true);
        openOPTSbutton2.SetActive(true);
        startGameButton.SetActive(true);

        whereIam = "endGameMenu";

        soundManagerScript.playClickSound();
    }

    public void openOptions()
    {
        OptionsObj.SetActive(true);
        openSHOPbutton.SetActive(false);
        openLBbutton.SetActive(false);
        openOPTSbutton.SetActive(false);

        openLBbutton2.SetActive(false);
        openSHOPbutton2.SetActive(false);
        openOPTSbutton2.SetActive(false);
        startGameButton.SetActive(false);

        whereIam = "options";

        soundManagerScript.playClickSound();
    }
    public void closeOptions()
    {
        OptionsObj.SetActive(false);
        openSHOPbutton.SetActive(true);
        openLBbutton.SetActive(true);
        openOPTSbutton.SetActive(true);

        openSHOPbutton2.SetActive(true);
        openLBbutton2.SetActive(true);
        openOPTSbutton2.SetActive(true);
        startGameButton.SetActive(true);

        whereIam = "endGameMenu";

        soundManagerScript.playClickSound();
    }

    public void watchRewardedAd()
    {
        videoWatch = true;
        //butonları ekrandan kaldır.
    }
    public void declineRewardedRequest()
    {
        gameManagerScript.VideoReq = false;
        gameManagerScript.watchVideoPanel.SetActive(false);
        gameManagerScript.bestScoreText.text = "Best" + "\n" + ((long)PlayerPrefs.GetFloat("highscore")).ToString();
        //new highscore, show it.
        gameManagerScript.powerBarObj.SetActive(false);
        gameManagerScript.endGamePanelActive = true;
        gameManagerScript.endGameMenuPanel.SetActive(true);

        PlayerPrefs.SetFloat("rewardScoreTemp", 0);
    }

    public void SoundSituation()
    {
        if(isSoundMuted == true) //KAPALIYSA AÇ
        {
            isSoundMuted = false;
            AudioListener AL = mainCamera.GetComponent<AudioListener>();
            AL.enabled = true;
            audioButtons[1].SetActive(false);
            audioButtons[0].SetActive(true);
        }
        else //AÇIKSA KAPAT
        {
            isSoundMuted = true;
            AudioListener AL = mainCamera.GetComponent<AudioListener>();
            AL.enabled = false;
            audioButtons[0].SetActive(false);
            audioButtons[1].SetActive(true);
        }
    }
}
