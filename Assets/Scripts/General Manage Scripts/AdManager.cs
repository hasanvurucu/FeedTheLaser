using System;
using UnityEngine;
using GoogleMobileAds.Api;
using GoogleMobileAds;
using UnityEngine.SceneManagement;

public class AdManager : MonoBehaviour {

	public RewardBasedVideoAd rewardBasedVideo;
	public InterstitialAd interstitial;

	public static int interstitialCounter;

	public GameObject watchVideoPanel;

    public InGameButtonManager buttonManagerScript;

    public gameManager gameManagerScript;
    public playerController playerControllerScript;

    public float sceneFadeStart = 0f;
    public bool isFadeStarted = false;
    public GameObject fadeInPanel;


    private int i;

	public void interstitialIncrease()
	{
		interstitialCounter++;
	}

	void Start () 
	{
		Debug.Log ("interstitialCounter is: " + interstitialCounter);

		RequestInterstitial ();

		rewardBasedVideo = RewardBasedVideoAd.Instance;

	//	rewardBasedVideo.OnAdClosed += HandleOnAdClosed;
	//	rewardBasedVideo.OnAdFailedToLoad += HandleOnAdFailedToLoad;
	//	rewardBasedVideo.OnAdLeavingApplication += HandleOnAdLeavingApplication;
	//	rewardBasedVideo.OnAdLoaded += HandleOnAdLoaded;
	//	rewardBasedVideo.OnAdOpening += HandleOnAdOpening;
		rewardBasedVideo.OnAdRewarded += HandleOnAdRewarded;
	//	rewardBasedVideo.OnAdStarted += HandleOnAdStarted;

		if (!(rewardBasedVideo.IsLoaded ()))
		{
			RequestRewardBased ();
		}

	}
	public void Update () 
	{

		if (interstitialCounter == 5 && gameManagerScript.death == true && gameManagerScript.afterDeathDelay >= 2f)
		{
            if (gameManagerScript.endGamePanelActive)
            {
                showInterstitial();
                interstitialCounter = 0;
            }
		}

		if (buttonManagerScript.videoWatch == true)
		{
            watchVideoPanel.SetActive(false);
            showRewardBased ();
            buttonManagerScript.videoWatch = false;
		}

        if(isFadeStarted == true)
        {
            sceneFadeStart += Time.deltaTime;
            fadeInPanel.SetActive(true);
        }

        if(sceneFadeStart >= 0.52f)
        {
            SceneManager.LoadScene("mainScene");
        }
	}

	public void RequestInterstitial()
	{
        //REAL: ca-app-pub-7543778288796089/2833551905
        //TEST: ca-app-pub-3940256099942544/1033173712
        string adUnitId = "ca-app-pub-3940256099942544/1033173712";

		interstitial = new InterstitialAd (adUnitId);

		AdRequest request = new AdRequest.Builder ().Build ();

		interstitial.LoadAd (request);
	}

	public void showInterstitial()
	{
		if (interstitial.IsLoaded ())
		{
			interstitial.Show();
		}
	}

	public void RequestRewardBased()
	{
        //REAL: ca-app-pub-7543778288796089/7866386735
        //TEST: ca-app-pub-3940256099942544/5224354917
        string adUnitId = "ca-app-pub-3940256099942544/5224354917";

		rewardBasedVideo.LoadAd (new AdRequest.Builder ().Build (), adUnitId);
	}

	public void showRewardBased()
	{
		if (rewardBasedVideo.IsLoaded ())
		{
			rewardBasedVideo.Show ();
		}
	}

    public void respawnToResumeMethod()
    {

    }

    /*
	public void HandleOnAdLoaded(object sender, EventArgs args)
	{
		//Make an offer to user.
	}
	public void HandleOnAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
	{
		//Try a reload.
	}
	public void HandleOnAdOpening(object sender, EventArgs args)
	{
        watchVideoPanel.SetActive(false);
	}
	public void HandleOnAdStarted(object sender, EventArgs args)
	{
		//Ex: mute audio
	}*/
    public void HandleOnAdClosed(object sender, EventArgs args)
	{
        gameManagerScript.watchVideoPanel.SetActive(false);

        gameManagerScript.bestScoreText.text = "Best" + "\n" + ((long)PlayerPrefs.GetFloat("highscore")).ToString();
        //new highscore, show it.
        gameManagerScript.powerBarObj.SetActive(false);
        gameManagerScript.endGamePanelActive = true;
        gameManagerScript.endGameMenuPanel.SetActive(true);
    } 
	public void HandleOnAdRewarded(object sender, Reward args)
	{
        //make animation appear, after that load main.
        //SceneManager.LoadScene("mainScene");

        isFadeStarted = true;

        PlayerPrefs.SetInt("gameLoop", 1);
        PlayerPrefs.SetInt("extraLife", 1);
    }
    
    /*
	public void HandleOnAdLeavingApplication(object sender, EventArgs args)
	{
		//No rewards because user quited the app!
	} */

	public event EventHandler<EventArgs> OnAdLoaded;

//	public event EventHandler<AdFailedToLoadEventArgs> OnAdFailedToLoad;

//	public event EventHandler<EventArgs> OnAdOpening;

//	public event EventHandler<EventArgs> OnAdStarted;

//	public event EventHandler<EventArgs> OnAdClosed;

	public event EventHandler<Reward> OnAdRewarded;

//	public event EventHandler<EventArgs> OnAdLeavingApplication;

//	public event EventHandler<EventArgs> OnAdCompleted;

}
