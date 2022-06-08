using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class usernameGetSetScript : MonoBehaviour {

	public InputField usernameInput;
	public Text username;
	public static string usernameReal;

    public Text changeLimitText;

	public GameObject panel;
	public static int usernameSet;
	public GameObject changeButton;

	void Awake()
	{
		usernameSet = PlayerPrefs.GetInt ("usernameSet");
		if(usernameSet == 0)
        {
            panel.SetActive(true);
        }
		else if (usernameSet >= 1)
		{
			panel.SetActive (false);
		} else
		{
			int i = Random.Range(1000, 9999999);
			username.text = "Guest" + i;
		}

		usernameReal = PlayerPrefs.GetString ("usernameReal", usernameReal);
		username.text = "User: " + usernameReal;

        if (usernameSet == 1)
        {
            changeLimitText.text = "Changes Left: 1";
        }
        else
        {
            changeLimitText.text = "Changes Left: 0";
        }
    }
    private void Start()
    {
        if(usernameSet == 0)
        {
            panel.SetActive(true);
        }
    }
    private void Update()
    {
        if (usernameSet == 1)
        {
            changeLimitText.text = "Changes Left: 1";
        }
        else
        {
            changeLimitText.text = "Changes Left: 0";
        }
    }

    public void setget()
	{
        if (usernameInput.text.Length <= 1 || usernameInput.text.Length >= 20)
        {
            //too long name / too short name uyarı yazıları
        }
        else
        {
            username.text = "User: " + usernameInput.text;
            usernameReal = usernameInput.text;
            Debug.Log("string: " + usernameReal);
            PlayerPrefs.SetString("usernameReal", usernameReal);
            
            if (usernameSet == 0)
            {
                usernameSet = 1; Debug.Log("set username = 1");
            }
            else if (usernameSet == 1)
            {
                usernameSet = 2; Debug.Log("setusername = 2");
            }
                
            PlayerPrefs.SetInt("usernameSet", usernameSet);

            panel.SetActive(false);
        }
	}

	public void activeUsernameChange()
	{
        if (usernameSet < 2)
        {
            Debug.Log("hi");
            panel.SetActive(true);
            changeButton.SetActive(false);
        }
        else
        {
            changeLimitText.text = "You can't change your username again!";
        }
	}
}
