using UnityEngine;

public class highscoreManager : MonoBehaviour
{
    public static float highscore;
    public gameManager gameManagerScript;
    // Start is called before the first frame update
    void Awake()
    {
        highscore = PlayerPrefs.GetFloat("highscore");
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManagerScript.score >= highscore)
        {
            PlayerPrefs.SetFloat("highscore", gameManagerScript.score);
        }
    }
}
