using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highscores : MonoBehaviour {

	const string privateCode = "U7W_0RQ7xECGg5F4ruGwwQvEjo-1LuA0yvml2mB_CguA";
	const string publicCode = "5d24e55d76827b1758aa8e77";
	const string webURL = "http://dreamlo.com/lb/";

	displayHighscores highscoreDisplay;
	public Highscore[] highscoresList;
	static Highscores instance;

	public static string usernameReal;
	public static int highscore;

	void Awake() {
        usernameReal = PlayerPrefs.GetString("usernameReal");
        highscore = (int)PlayerPrefs.GetFloat("highscore");
        instance = this;
        highscoreDisplay = GetComponent<displayHighscores> ();
		AddNewHighscore (usernameReal, highscore);
	}

    public static void AddNewHighscore(string username, int score) {
		instance.StartCoroutine(instance.UploadNewHighscore(username,score));
	}

    public void callForUpload()
    {
        highscore = (int)PlayerPrefs.GetFloat("highscore");
        AddNewHighscore(usernameReal, highscore);
    }

	IEnumerator UploadNewHighscore(string username, int score) {
		WWW www = new WWW(webURL + privateCode + "/add/" + WWW.EscapeURL(username) + "/" + score);
		yield return www;

		highscore = (int)PlayerPrefs.GetFloat("highscore");

        if (string.IsNullOrEmpty(www.error)) {
			print ("Upload Successful");
			DownloadHighscores();
		}
		else {
			print ("Error uploading: " + www.error);
		}
	}

	public void DownloadHighscores() {
		StartCoroutine("DownloadHighscoresFromDatabase");
	}

	IEnumerator DownloadHighscoresFromDatabase() {
		WWW www = new WWW(webURL + publicCode + "/pipe/");
		yield return www;

		if (string.IsNullOrEmpty (www.error)) {
			FormatHighscores (www.text);
			highscoreDisplay.OnHighscoresDownloaded(highscoresList);
		}
		else {
			print ("Error Downloading: " + www.error);
		}
	}

	void FormatHighscores(string textStream) {
		string[] entries = textStream.Split(new char[] {'\n'}, System.StringSplitOptions.RemoveEmptyEntries);
		highscoresList = new Highscore[entries.Length];
		usernameReal = PlayerPrefs.GetString ("usernameReal");
		for (int i = 0; i <entries.Length; i ++) {
			string[] entryInfo = entries[i].Split(new char[] {'|'});
			string username = entryInfo[0];
			int score = int.Parse(entryInfo[1]);
		//	score = highscore;
			highscoresList[i] = new Highscore(username,score);
			print (highscoresList[i].username + ": " + highscoresList[i].score);
		}
	}

}

public struct Highscore {
	public string username;
	public int score;

	public Highscore(string _username, int _score) {
		username = _username;
		score = _score;
	}

}