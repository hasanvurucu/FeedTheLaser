using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public bool IsGameStarted = false;
    public bool IsGamePaused = false;
    public float unpauseTimer = 0f;
    public bool pTimerStart = false;
    public GameObject startPanel;
    public GameObject tapToResumePanel;
    public GameObject pauseButton;
    public GameObject scoreTextObj;
    public GameObject highscoreTextObj;
    public GameObject powerBarObj;
    public Image scoreBg;

    public GameObject endGameMenuPanel;
    public bool endGamePanelActive = false;
    public Text bestScoreText;

    public generalMovement generalMovementScript;

    public float score;
    public float power;
    public int powerLoseLevel;
    public float powerLoseTimer;
    public float pointMultiplier = 1;
    private float x2timer = 0;
    public int levelReference;

    public Text scoreText;
    public Text scoreByLevelText;
    public Text highscoreText;
  //  public Text powerText; //Will turn into a "bar" later.

    public laserHit laserHitScript;
    public playerController playerControllerScript;
    public levelXPManager levelXPManagerScript;
    public highscoreManager highscoreManagerScript;

    public float afterDeathDelay = 0f;
    public GameObject deathEffectParticle;
    public bool death;

    public ParticleSystem hitParticles;

    public Text x2Text;
    public GameObject x2TextAnimated;
    public Text lvlSidePanelText;

    public AdManager AdManagerScript;
    public GameObject watchVideoPanel;

    public soundManager soundManagerScript;

    public int gameLoop;

    public bool VideoReq;

    public float rewardScoreTemp;

    float FadeOutTimer = 0f;
    public GameObject fadeOutPanel;

    private float videoChanceCountdown;
    private bool IsCountdownStarted;
    public Image countdownImage;

    public Camera mainCamera;
    private int cameraBgCount = 0;
    private float cameraBgChangeTimer = 0f;
    public Animation anim;

    private InGameButtonManager InGameButtonManagerScript;

    void Start()
    {
        mainCamera.backgroundColor = new Color(0.38f, 0.06f, 0.44f, 1);

        InGameButtonManagerScript = GetComponent<InGameButtonManager>();
        fadeOutPanel.SetActive(true);
        soundManagerScript = GetComponent<soundManager>();
        soundManagerScript.closeDieSound();

        death = false;
     // score = 0f;
        power = 1f;

        startPanel.SetActive(true);
        tapToResumePanel.SetActive(false);
        pauseButton.SetActive(false);
        scoreTextObj.SetActive(false);
        highscoreTextObj.SetActive(false);
        watchVideoPanel.SetActive(false);

        deathEffectParticle.SetActive(false);

        powerLoseLevel = 0;
        powerLoseTimer = 0f;

        endGameMenuPanel.SetActive(false);

        rewardScoreTemp = PlayerPrefs.GetFloat("rewardScoreTemp");
       /* if (rewardScoreTemp != 0)
            PlayerPrefs.SetInt("gameLoop", 1); */

        gameLoop = PlayerPrefs.GetInt("gameLoop");
        if(gameLoop == 1)
        {
            startGameButton();
        }

        AdManagerScript.interstitialIncrease();

        rewardScoreTemp = PlayerPrefs.GetFloat("rewardScoreTemp");
        if (PlayerPrefs.GetInt("extraLife") == 1)
        {
            generalMovementScript.speed = PlayerPrefs.GetFloat("rewardSpeedTemp");
            score = PlayerPrefs.GetFloat("rewardScoreTemp");

            PlayerPrefs.SetFloat("rewardSpeedTemp", 0);
            PlayerPrefs.SetFloat("rewardScoreTemp", 0);

            PlayerPrefs.SetInt("extraLife", 0);

            VideoReq = false;
            pauseGame();
        }
        else
        {
            VideoReq = true;
        }

        setTextMethod();

        videoChanceCountdown = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsGamePaused != true && IsGameStarted == true && death == false)
        {
            cameraBgChangeTimer += Time.deltaTime;
        }
        if(cameraBgChangeTimer >= 30f)
        {
            //play anim.

            if(cameraBgCount == 0)
            {
                anim.Play("CameraAnim1");
                cameraBgChangeTimer = 0f;
            }else if(cameraBgCount == 1)
            {
                anim.Play("CameraAnim2");
                cameraBgChangeTimer = 0f;
            }else if(cameraBgCount == 2)
            {
                anim.Play("CameraAnim3");
                cameraBgChangeTimer = 0f;
            }else if(cameraBgCount == 3)
            {
                anim.Play("CameraAnim4");
                cameraBgChangeTimer = 0f;
            }

            if (cameraBgCount != 4)
            {
                cameraBgCount++;
                Debug.Log("Camera BG count is: " + cameraBgCount);
            }else
            {
                cameraBgCount = 0;
            }
        }

        FadeOutTimer += Time.deltaTime;
        if(FadeOutTimer >= 0.52f)
        {
            fadeOutPanel.SetActive(false);
        }

        if(IsCountdownStarted == true)
        {
            videoChanceCountdown -= Time.deltaTime;
            countdownImage.fillAmount = videoChanceCountdown / 5f;

            if(videoChanceCountdown <= 0f)
            {
                IsCountdownStarted = false;
                videoChanceCountdown = 0f;
                InGameButtonManagerScript.declineRewardedRequest();
            }
        }

        gameStartAndPauseManager();
        levelReference = levelXPManagerScript.level;
        lvlSidePanelText.text = "x" + levelReference.ToString();


        if (IsGameStarted == true && IsGamePaused != true)
        {
            powerController();
            deathCheck();
            setTextMethod();
        }

        if (IsGamePaused == true)
        {
            if(Input.GetMouseButtonUp(0))
            {
                pTimerStart = true;
            }
            if (pTimerStart == true)
            {
                unpauseTimer += Time.deltaTime;
            }
        }

        if(death == true)
        {
            var em = hitParticles.emission;
            em.enabled = false;
        }

        pointMultiplySpecialsMethod();

        if (IsGamePaused == false)
            if (IsGameStarted == true && death != true)
                score += Time.deltaTime * levelReference * pointMultiplier;
    }

    public void FixedUpdate()
    {
        if(death != true)
        {
            PlayerPrefs.SetFloat("rewardScoreTemp", score);
            PlayerPrefs.SetFloat("rewardSpeedTemp", generalMovementScript.speed);
        }
        if (IsGamePaused == false)
        {
            //if (IsGameStarted == true && death != true)
            //score += Time.fixedDeltaTime * 3 * levelXPManagerScript.level * pointMultiplier;
            if (death == false)
            {
                if (playerControllerScript.transform.position.z <= -10f)
                {
                    if (powerLoseLevel == 0)
                    {
                        power -= Time.fixedDeltaTime / 15;
                        powerLoseTimer += Time.fixedDeltaTime;
                        if (powerLoseTimer >= 1f)
                        {
                            powerLoseLevel = 1;
                            powerLoseTimer = 0f;
                        }
                    }
                    else if (powerLoseLevel == 1)
                    {
                        power -= Time.fixedDeltaTime / 8.5f;
                        powerLoseTimer += Time.fixedDeltaTime;
                        if (powerLoseTimer >= 0.7f)
                        {
                            powerLoseLevel = 2;
                            powerLoseTimer = 0f;
                        }
                    }
                    else if (powerLoseLevel == 2)
                    {
                        power -= Time.fixedDeltaTime / 5;
                        powerLoseTimer += Time.fixedDeltaTime;
                        if (powerLoseTimer >= 0.7f)
                        {
                            powerLoseLevel = 3;
                            powerLoseTimer = 0f;
                        }
                    }
                    else if (powerLoseLevel == 3)
                    {
                        power -= Time.fixedDeltaTime / 3.5f;
                        powerLoseTimer += Time.fixedDeltaTime;
                        if (powerLoseTimer >= 0.7f)
                        {
                            powerLoseLevel = 4;
                            powerLoseTimer = 0f;
                        }
                    }
                    else if (powerLoseLevel == 4)
                    {
                        power -= Time.fixedDeltaTime / 2.2f;
                    }
                }
            }
        }
        //score += (Time.fixedDeltaTime * 10) * 2
        //score += (Time.fixedDeltaTime * 10) * level
        //puan değişimini etkileyen faktörler.

        //Debug.Log("Score is: " + (long)score);
    }

    public void powerController()
    {
        if (power >= 1f) //max power value is 1
        {
            power = 1;
        }

        
        if (laserHitScript.hitSituation == 1 && IsGamePaused != true) //BLACK
        {
            power -= 0.04f;
            scoreText.color = new Color(0.55f, 0.55f, 0.55f, 1f);//Color.black;
            
        }
        else if(laserHitScript.hitSituation == 2) //YELLOW
        {
            power += 0.01f;
            score += 1f * levelXPManagerScript.level * pointMultiplier ;
            scoreText.color = Color.red;
            powerLoseLevel = 0;
        }
        if(laserHitScript.hitSituation == 3 && IsGamePaused != true)
        {
            power = -0.0001f; //dies directly
        }

        if (laserHitScript.hitSituation == 0)
        {
            if (score >= PlayerPrefs.GetFloat("highscore"))
            {
                Color newColor = new Color(0.21f, 0.22f, 0.99f, 1f);
                scoreText.color = newColor;
            }
            else
            {
                scoreText.color = Color.black;
                scoreText.color = new Color(0.55f, 0.55f, 0.55f, 1f);//Color.black;
            }
        }
    }

    public void deathCheck()
    {
        if(power <= 0)
        {
            death = true;
            afterDeathDelay += Time.deltaTime;
            deathEffectParticle.SetActive(true);
            
            
            generalMovementScript.speed = 0f;
            pauseButton.SetActive(false);
            //VideoReq = true;

            soundManager soundManagerScript = GetComponent<soundManager>();
            soundManagerScript.openDieSound();

            if (afterDeathDelay >= 2f)
            {
                if (AdManagerScript.rewardBasedVideo.IsLoaded() && VideoReq == true)
                {
                    watchVideoPanel.SetActive(true);
                    IsCountdownStarted = true;
                }
                else//video not loaded or watched once
                {
                    watchVideoPanel.SetActive(false);
                    Debug.Log("Game Over!");
                    //death here & end game menu appears
                    bestScoreText.text = "Best" + "\n" + ((long)PlayerPrefs.GetFloat("highscore")).ToString();
                    //new highscore, show it.
                    powerBarObj.SetActive(false);

                    Color newColor = new Color(scoreBg.color.r, scoreBg.color.g, scoreBg.color.b, 0f);
                    scoreBg.color = newColor;

                    endGamePanelActive = true;
                    endGameMenuPanel.SetActive(true);
                }
            }
        }
    }

    public void setTextMethod()
    {
        if(score >= 1000000)
        {
            scoreText.text = ((int)(score) / 1000000).ToString() + "." + (((score%1000000) - (score%100000))/100000).ToString() + "m";
        }else if(score >= 1000)
        {
            scoreText.text = ((int)(score) / 1000).ToString() + "." + (((score % 1000) - (score % 100)) / 100).ToString() + "k";
        }else
        {
            scoreText.text = ((long)score).ToString();
        }
        scoreByLevelText.text = "x" + levelXPManagerScript.level.ToString();

        if(score >= PlayerPrefs.GetFloat("highscore"))
        {
            highscoreText.text = "New Best!";
        }

        //highscoreText.text = "Highscore: " + ((long)PlayerPrefs.GetFloat("highscore"));
        //powerText.text = "Power: " + power.ToString();
    }

    public void startGameButton()
    {
        soundManager soundManagerScript = GetComponent<soundManager>();
        if(IsGameStarted == false)
        {
            if(PlayerPrefs.GetInt("gameLoop") == 0)
            {
                soundManagerScript.playClickSound();
            }
            PlayerPrefs.SetInt("gameLoop", 1);
            startGame();
            IsGameStarted = true;
        }
    }

    public void gameStartAndPauseManager()
    {/*
        if (IsGameStarted == false)
        {
            if (Input.GetMouseButtonUp(0))
            {
                startGame();
                IsGameStarted = true;
            }
        } 
    */
        if (IsGamePaused == false)
        {
            //pause button functions
        }
        
        if(IsGamePaused == true)
        {
          /* int i;
            if (unpauseTimer >= 0.05f)
            {
                i = PlayerPrefs.GetInt("tutorialDone");
                if (i == 1)
                {
                    if (Input.GetMouseButtonUp(0))
                    {
                        Debug.Log("game UNPAUSED!!!");
                        unpauseGame();
                        unpauseTimer = 0f;
                        pTimerStart = false;
                    }
                }
            }*/
        }
    }

    public void startGame()
    {
        //tapToPlayPanel.SetActive(false);
        startPanel.SetActive(false);
        pauseButton.SetActive(true);
        scoreTextObj.SetActive(true);
        highscoreTextObj.SetActive(true);
        tutorialManager tutM;
        tutM = GetComponent<tutorialManager>();
        tutM.gameIsStarted = true;
    }

    public void unpauseGame()
    {
        tapToResumePanel.SetActive(false);
        pauseButton.SetActive(true);

        //unpauseGame();
        unpauseTimer = 0f;
        pTimerStart = false;

        generalMovementScript.speed = generalMovementScript.speedTemp;
        Debug.Log("gameUnpaused");
        IsGamePaused = false;
    }
    
    public void pauseGame()
    {
        IsGamePaused = true;

        tapToResumePanel.SetActive(true);
        pauseButton.SetActive(false);

        generalMovementScript.speedTemp = generalMovementScript.speed;
        generalMovementScript.speed = 0f;
    }

    private void pointMultiplySpecialsMethod()
    {
     /*   if (pointMultiplier == 3)
        {
            x3Text.color = Color.red;
            x2Text.color = Color.white;
            if (IsGamePaused != true)
            {
                x3timer += Time.deltaTime;

                //meanwhile player gains x3 points

                if (x3timer >= 10f)
                {
                    Debug.Log("x3 points ended");
                    pointMultiplier = 1;
                    x3timer = 0f;
                }
            }
        } */
        if (pointMultiplier == 2)
        {
            x2TextAnimated.SetActive(true);
            x2Text.text = "";
            if (IsGamePaused != true)
            {
                x2timer += Time.deltaTime;

                //meanwhile player gains x2 points

                if (x2timer >= 10f)
                {
                    Debug.Log("x2 points ended");
                    pointMultiplier = 1;
                    x2timer = 0f;
                }
            }
        }
        else
        {
            x2Text.text = "x2";
            x2TextAnimated.SetActive(false);
        }

        
    }
}
