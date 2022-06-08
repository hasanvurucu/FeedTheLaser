using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class displayHighscores : MonoBehaviour {

	public Text[] highscoreNameFields;
    public Text[] bestScoreFields;
    public Text usersOwnDataField;
    public Text usersOwnScoreField;
	Highscores highscoresManager;
    
    private char[] displayTemp;

    public bool top1000check = false;

	public static string usernameReal;

	void Start() {
		for (int i = 0; i < highscoreNameFields.Length; i++) {
            highscoreNameFields[i].text = i+1 + ". Fetching...";
		}
        for(int i = 0; i < bestScoreFields.Length; i++)
        {
            bestScoreFields[i].text = "...";
        }

        usersOwnDataField.text = "...";
        usersOwnScoreField.text = "...";

		usernameReal = PlayerPrefs.GetString ("usernameReal", usernameReal);

		highscoresManager = GetComponent<Highscores>();
		StartCoroutine("RefreshHighscores");

	}

	public void OnHighscoresDownloaded(Highscore[] highscoreList) {
		int i;
        int j;
        for (i =0; i < highscoreNameFields.Length; i ++) {
            highscoreNameFields[i].text = i+1 + ". ";
			if (i < highscoreList.Length) {

                displayTemp = highscoreList[i].username.ToCharArray();
                for(j = 0; j < highscoreList[i].username.Length; j++)
                {
                    if (displayTemp[j] == '+')
                    {
                        displayTemp[j] = ' ';
                    }
                }
                for (j = 0; j < highscoreList[i].username.Length; j++)
                {
                    highscoreNameFields[i].text += displayTemp[j].ToString();//highscoreList[i].username;//highscoreList[i].score;
                }

                if (highscoreList[i].score >= 1000000)
                {
                    bestScoreFields[i].text = ((int)(highscoreList[i].score) / 1000000).ToString() + "." + (((highscoreList[i].score % 1000000) - (highscoreList[i].score % 100000)) / 100000).ToString() + "m";
                }
                else if (highscoreList[i].score >= 1000)
                {
                    bestScoreFields[i].text = ((int)(highscoreList[i].score) / 1000).ToString() + "." + (((highscoreList[i].score % 1000) - (highscoreList[i].score % 100)) / 100).ToString() + "k";
                }
                else
                {
                    bestScoreFields[i].text = highscoreList[i].score.ToString();
                }
            }
		}
		for (i = 0; i < highscoreList.Length; i++)
		{
            
            displayTemp = highscoreList[i].username.ToCharArray();
            for (j = 0; j < highscoreList[i].username.Length; j++)
            {
                if (displayTemp[j] == '+')
                {
                    displayTemp[j] = ' ';
                }
            }

            //display current rank
            if (new string(displayTemp) == usernameReal)
			{
                usersOwnDataField.text = i+1 + ". ";
                usersOwnDataField.text += new string(displayTemp);//highscoreList[i].username;
                //usersOwnScoreField.text
                if (highscoreList[i].score >= 1000000)
                {
                    usersOwnScoreField.text = ((int)(highscoreList[i].score) / 1000000).ToString() + "." + (((highscoreList[i].score % 1000000) - (highscoreList[i].score % 100000)) / 100000).ToString() + "m";
                }
                else if (highscoreList[i].score >= 1000)
                {
                    usersOwnScoreField.text = ((int)(highscoreList[i].score) / 1000).ToString() + "." + (((highscoreList[i].score % 1000) - (highscoreList[i].score % 100)) / 100).ToString() + "k";
                }
                else
                {
                    usersOwnScoreField.text = highscoreList[i].score.ToString();
                }
                top1000check = true;
			}
		}
		if (top1000check == false)
		{
            usersOwnDataField.text = "You're not in top 1000 :(";
		}
	}

	IEnumerator RefreshHighscores() {
		while (true) {
			highscoresManager.DownloadHighscores();
			yield return new WaitForSeconds(30);
		}
	}
}