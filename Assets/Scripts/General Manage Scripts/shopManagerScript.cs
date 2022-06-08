using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shopManagerScript : MonoBehaviour
{
    public GameObject playerObj;
    public GameObject pDeathParticleObj;

    public Button[] buttons;

    private gameManager gameManagerScript;

    public Material[] playerSkins;

    public GameObject[] pricePanels;

    public static int money;
    public Text endPanelMoneyText;

    public static int selectedSkin;

    //skin 0 is default skin (white)
    public static int IsBoughtSkin1;
    public static int IsBoughtSkin2;
    public static int IsBoughtSkin3;
    public static int IsBoughtSkin4;
    public static int IsBoughtSkin5;
    public static int IsBoughtSkin6;
    public static int IsBoughtSkin7;
    public static int IsBoughtSkin8;
    public static int IsBoughtSkin9;
    public static int IsBoughtSkin10;
    public static int IsBoughtSkin11;
    public static int IsBoughtSkin12;
    public static int IsBoughtSkin13;
    public static int IsBoughtSkin14;
    public static int IsBoughtSkin15;
    public static int IsBoughtSkin16;
    public static int IsBoughtSkin17;
    public static int IsBoughtSkin18;
    public static int IsBoughtSkin19;
    public static int IsBoughtSkin20;
    public static int IsBoughtSkin21;
    public static int IsBoughtSkin22;
    public static int IsBoughtSkin23;
    public static int IsBoughtSkin24;
    public static int IsBoughtSkin25;
    public static int IsBoughtSkin26;
    public static int IsBoughtSkin27;
    public static int IsBoughtSkin28;
    public static int IsBoughtSkin29;
    public static int IsBoughtSkin30;
    public static int IsBoughtSkin31;
    public static int IsBoughtSkin32;
    public static int IsBoughtSkin33;
    public static int IsBoughtSkin34;
    public static int IsBoughtSkin35;
    public static int IsBoughtSkin36;
    public static int IsBoughtSkin37;
    public static int IsBoughtSkin38;

    private int cost20 = 20; //1-8
    private int cost45 = 45; //9-17
    private int cost50 = 50; //18-23
    private int cost65 = 65; //24-32
    private int cost100 = 100; //33-38


    void Start()
    {
        gameManagerScript = GetComponent<gameManager>();
        
        money = PlayerPrefs.GetInt("money");
        PlayerPrefs.SetInt("money", money);

        selectedSkin = PlayerPrefs.GetInt("selectedSkin");
        PlayerPrefs.SetInt("selectedSkin", selectedSkin);

        IsBoughtSkin1 = PlayerPrefs.GetInt("IsBoughtSkin1");
        IsBoughtSkin2 = PlayerPrefs.GetInt("IsBoughtSkin2");
        IsBoughtSkin3 = PlayerPrefs.GetInt("IsBoughtSkin3");
        IsBoughtSkin4 = PlayerPrefs.GetInt("IsBoughtSkin4");
        IsBoughtSkin5 = PlayerPrefs.GetInt("IsBoughtSkin5");
        IsBoughtSkin6 = PlayerPrefs.GetInt("IsBoughtSkin6");
        IsBoughtSkin7 = PlayerPrefs.GetInt("IsBoughtSkin7");
        IsBoughtSkin8 = PlayerPrefs.GetInt("IsBoughtSkin8");
        IsBoughtSkin9 = PlayerPrefs.GetInt("IsBoughtSkin9");
        IsBoughtSkin10 = PlayerPrefs.GetInt("IsBoughtSkin10");
        IsBoughtSkin11 = PlayerPrefs.GetInt("IsBoughtSkin11");
        IsBoughtSkin12 = PlayerPrefs.GetInt("IsBoughtSkin12");
        IsBoughtSkin13 = PlayerPrefs.GetInt("IsBoughtSkin13");
        IsBoughtSkin14 = PlayerPrefs.GetInt("IsBoughtSkin14");
        IsBoughtSkin15 = PlayerPrefs.GetInt("IsBoughtSkin15");
        IsBoughtSkin16 = PlayerPrefs.GetInt("IsBoughtSkin16");
        IsBoughtSkin17 = PlayerPrefs.GetInt("IsBoughtSkin17");
        IsBoughtSkin18 = PlayerPrefs.GetInt("IsBoughtSkin18");
        IsBoughtSkin19 = PlayerPrefs.GetInt("IsBoughtSkin19");
        IsBoughtSkin20 = PlayerPrefs.GetInt("IsBoughtSkin20");
        IsBoughtSkin21 = PlayerPrefs.GetInt("IsBoughtSkin21");
        IsBoughtSkin22 = PlayerPrefs.GetInt("IsBoughtSkin22");
        IsBoughtSkin23 = PlayerPrefs.GetInt("IsBoughtSkin23");
        IsBoughtSkin24 = PlayerPrefs.GetInt("IsBoughtSkin24");
        IsBoughtSkin25 = PlayerPrefs.GetInt("IsBoughtSkin25");
        IsBoughtSkin26 = PlayerPrefs.GetInt("IsBoughtSkin26");
        IsBoughtSkin27 = PlayerPrefs.GetInt("IsBoughtSkin27");
        IsBoughtSkin28 = PlayerPrefs.GetInt("IsBoughtSkin28");
        IsBoughtSkin29 = PlayerPrefs.GetInt("IsBoughtSkin29");
        IsBoughtSkin30 = PlayerPrefs.GetInt("IsBoughtSkin30");
        IsBoughtSkin31 = PlayerPrefs.GetInt("IsBoughtSkin31");
        IsBoughtSkin32 = PlayerPrefs.GetInt("IsBoughtSkin32");
        IsBoughtSkin33 = PlayerPrefs.GetInt("IsBoughtSkin33");
        IsBoughtSkin34 = PlayerPrefs.GetInt("IsBoughtSkin34");
        IsBoughtSkin35 = PlayerPrefs.GetInt("IsBoughtSkin35");
        IsBoughtSkin36 = PlayerPrefs.GetInt("IsBoughtSkin36");
        IsBoughtSkin37 = PlayerPrefs.GetInt("IsBoughtSkin37");
        IsBoughtSkin38 = PlayerPrefs.GetInt("IsBoughtSkin38");

        PlayerPrefs.SetInt("IsBoughtSkin1", IsBoughtSkin1);
        PlayerPrefs.SetInt("IsBoughtSkin2", IsBoughtSkin2);
        PlayerPrefs.SetInt("IsBoughtSkin3", IsBoughtSkin3);
        PlayerPrefs.SetInt("IsBoughtSkin4", IsBoughtSkin4);
        PlayerPrefs.SetInt("IsBoughtSkin5", IsBoughtSkin5);
        PlayerPrefs.SetInt("IsBoughtSkin6", IsBoughtSkin6);
        PlayerPrefs.SetInt("IsBoughtSkin7", IsBoughtSkin7);
        PlayerPrefs.SetInt("IsBoughtSkin8", IsBoughtSkin8);
        PlayerPrefs.SetInt("IsBoughtSkin9", IsBoughtSkin9);
        PlayerPrefs.SetInt("IsBoughtSkin10", IsBoughtSkin10);
        PlayerPrefs.SetInt("IsBoughtSkin11", IsBoughtSkin11);
        PlayerPrefs.SetInt("IsBoughtSkin12", IsBoughtSkin12);
        PlayerPrefs.SetInt("IsBoughtSkin13", IsBoughtSkin13);
        PlayerPrefs.SetInt("IsBoughtSkin14", IsBoughtSkin14);
        PlayerPrefs.SetInt("IsBoughtSkin15", IsBoughtSkin15);
        PlayerPrefs.SetInt("IsBoughtSkin16", IsBoughtSkin16);
        PlayerPrefs.SetInt("IsBoughtSkin17", IsBoughtSkin17);
        PlayerPrefs.SetInt("IsBoughtSkin18", IsBoughtSkin18);
        PlayerPrefs.SetInt("IsBoughtSkin19", IsBoughtSkin19);
        PlayerPrefs.SetInt("IsBoughtSkin20", IsBoughtSkin20);
        PlayerPrefs.SetInt("IsBoughtSkin21", IsBoughtSkin21);
        PlayerPrefs.SetInt("IsBoughtSkin22", IsBoughtSkin22);
        PlayerPrefs.SetInt("IsBoughtSkin23", IsBoughtSkin23);
        PlayerPrefs.SetInt("IsBoughtSkin24", IsBoughtSkin24);
        PlayerPrefs.SetInt("IsBoughtSkin25", IsBoughtSkin25);
        PlayerPrefs.SetInt("IsBoughtSkin26", IsBoughtSkin26);
        PlayerPrefs.SetInt("IsBoughtSkin27", IsBoughtSkin27);
        PlayerPrefs.SetInt("IsBoughtSkin28", IsBoughtSkin28);
        PlayerPrefs.SetInt("IsBoughtSkin29", IsBoughtSkin29);
        PlayerPrefs.SetInt("IsBoughtSkin30", IsBoughtSkin30);
        PlayerPrefs.SetInt("IsBoughtSkin31", IsBoughtSkin31);
        PlayerPrefs.SetInt("IsBoughtSkin32", IsBoughtSkin32);
        PlayerPrefs.SetInt("IsBoughtSkin33", IsBoughtSkin33);
        PlayerPrefs.SetInt("IsBoughtSkin34", IsBoughtSkin34);
        PlayerPrefs.SetInt("IsBoughtSkin35", IsBoughtSkin35);
        PlayerPrefs.SetInt("IsBoughtSkin36", IsBoughtSkin36);
        PlayerPrefs.SetInt("IsBoughtSkin37", IsBoughtSkin37);
        PlayerPrefs.SetInt("IsBoughtSkin38", IsBoughtSkin38);

        //panel1
        if(IsBoughtSkin1 == 1)
        {
            pricePanels[0].SetActive(false);
        }
        else
        {
            pricePanels[0].SetActive(true);
        }

        //panel2
        if (IsBoughtSkin2 == 1)
        {
            pricePanels[1].SetActive(false);
        }
        else
        {
            pricePanels[1].SetActive(true);
        }

        //panel3
        if (IsBoughtSkin3 == 1)
        {
            pricePanels[2].SetActive(false);
        }
        else
        {
            pricePanels[2].SetActive(true);
        }

        //panel4
        if (IsBoughtSkin4 == 1)
        {
            pricePanels[3].SetActive(false);
        }
        else
        {
            pricePanels[3].SetActive(true);
        }

        //panel5
        if (IsBoughtSkin5 == 1)
        {
            pricePanels[4].SetActive(false);
        }
        else
        {
            pricePanels[4].SetActive(true);
        }

        //panel6
        if (IsBoughtSkin6 == 1)
        {
            pricePanels[5].SetActive(false);
        }
        else
        {
            pricePanels[5].SetActive(true);
        }

        //panel7
        if (IsBoughtSkin7 == 1)
        {
            pricePanels[6].SetActive(false);
        }
        else
        {
            pricePanels[6].SetActive(true);
        }

        //panel8
        if (IsBoughtSkin8 == 1)
        {
            pricePanels[7].SetActive(false);
        }
        else
        {
            pricePanels[7].SetActive(true);
        }

        //panel9
        if (IsBoughtSkin9 == 1)
        {
            pricePanels[8].SetActive(false);
        }
        else
        {
            pricePanels[8].SetActive(true);
        }

        //panel10
        if (IsBoughtSkin10 == 1)
        {
            pricePanels[9].SetActive(false);
        }
        else
        {
            pricePanels[9].SetActive(true);
        }

        //panel11
        if (IsBoughtSkin11 == 1)
        {
            pricePanels[10].SetActive(false);
        }
        else
        {
            pricePanels[10].SetActive(true);
        }

        //panel12
        if (IsBoughtSkin12 == 1)
        {
            pricePanels[11].SetActive(false);
        }
        else
        {
            pricePanels[11].SetActive(true);
        }

        //panel13
        if (IsBoughtSkin13 == 1)
        {
            pricePanels[12].SetActive(false);
        }
        else
        {
            pricePanels[12].SetActive(true);
        }

        //panel14
        if (IsBoughtSkin14 == 1)
        {
            pricePanels[13].SetActive(false);
        }
        else
        {
            pricePanels[13].SetActive(true);
        }

        //panel15
        if (IsBoughtSkin15 == 1)
        {
            pricePanels[14].SetActive(false);
        }
        else
        {
            pricePanels[14].SetActive(true);
        }

        //panel16
        if (IsBoughtSkin16 == 1)
        {
            pricePanels[15].SetActive(false);
        }
        else
        {
            pricePanels[15].SetActive(true);
        }

        //panel17
        if (IsBoughtSkin17 == 1)
        {
            pricePanels[16].SetActive(false);
        }
        else
        {
            pricePanels[16].SetActive(true);
        }

        //panel18
        if (IsBoughtSkin18 == 1)
        {
            pricePanels[17].SetActive(false);
        }
        else
        {
            pricePanels[17].SetActive(true);
        }

        //panel19
        if (IsBoughtSkin19 == 1)
        {
            pricePanels[18].SetActive(false);
        }
        else
        {
            pricePanels[18].SetActive(true);
        }

        //panel20
        if (IsBoughtSkin20 == 1)
        {
            pricePanels[19].SetActive(false);
        }
        else
        {
            pricePanels[19].SetActive(true);
        }

        //panel21
        if (IsBoughtSkin21 == 1)
        {
            pricePanels[20].SetActive(false);
        }
        else
        {
            pricePanels[20].SetActive(true);
        }

        //panel22
        if (IsBoughtSkin22 == 1)
        {
            pricePanels[21].SetActive(false);
        }
        else
        {
            pricePanels[21].SetActive(true);
        }

        //panel23
        if (IsBoughtSkin23 == 1)
        {
            pricePanels[22].SetActive(false);
        }
        else
        {
            pricePanels[22].SetActive(true);
        }

        //panel24
        if (IsBoughtSkin24 == 1)
        {
            pricePanels[23].SetActive(false);
        }
        else
        {
            pricePanels[23].SetActive(true);
        }

        //panel25
        if (IsBoughtSkin25 == 1)
        {
            pricePanels[24].SetActive(false);
        }
        else
        {
            pricePanels[24].SetActive(true);
        }

        //panel26
        if (IsBoughtSkin26 == 1)
        {
            pricePanels[25].SetActive(false);
        }
        else
        {
            pricePanels[25].SetActive(true);
        }

        //panel27
        if (IsBoughtSkin27 == 1)
        {
            pricePanels[26].SetActive(false);
        }
        else
        {
            pricePanels[26].SetActive(true);
        }

        //panel28
        if (IsBoughtSkin28 == 1)
        {
            pricePanels[27].SetActive(false);
        }
        else
        {
            pricePanels[27].SetActive(true);
        }

        //panel29
        if (IsBoughtSkin29 == 1)
        {
            pricePanels[28].SetActive(false);
        }
        else
        {
            pricePanels[28].SetActive(true);
        }

        //panel30
        if (IsBoughtSkin30 == 1)
        {
            pricePanels[29].SetActive(false);
        }
        else
        {
            pricePanels[29].SetActive(true);
        }

        //panel31
        if (IsBoughtSkin31 == 1)
        {
            pricePanels[30].SetActive(false);
        }
        else
        {
            pricePanels[30].SetActive(true);
        }

        //panel32
        if (IsBoughtSkin32 == 1)
        {
            pricePanels[31].SetActive(false);
        }
        else
        {
            pricePanels[31].SetActive(true);
        }

        //panel33
        if (IsBoughtSkin33 == 1)
        {
            pricePanels[32].SetActive(false);
        }
        else
        {
            pricePanels[32].SetActive(true);
        }

        //panel34
        if (IsBoughtSkin34 == 1)
        {
            pricePanels[33].SetActive(false);
        }
        else
        {
            pricePanels[33].SetActive(true);
        }

        //panel35
        if (IsBoughtSkin35 == 1)
        {
            pricePanels[34].SetActive(false);
        }
        else
        {
            pricePanels[34].SetActive(true);
        }

        //panel36
        if (IsBoughtSkin36 == 1)
        {
            pricePanels[35].SetActive(false);
        }
        else
        {
            pricePanels[35].SetActive(true);
        }

        //panel37
        if (IsBoughtSkin37 == 1)
        {
            pricePanels[36].SetActive(false);
        }
        else
        {
            pricePanels[36].SetActive(true);
        }

        //panel38
        if (IsBoughtSkin38 == 1)
        {
            pricePanels[37].SetActive(false);
        }
        else
        {
            pricePanels[37].SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        checkSkinIsBought();

        setMoneyTextEndGame();
        if (gameManagerScript.death != true)
        {
            playerObj.GetComponent<Renderer>().material = playerSkins[selectedSkin];
        }
        pDeathParticleObj.GetComponent<Renderer>().material = playerSkins[selectedSkin];

        for (int i = 0; i < 39; i++)
        {
            if (selectedSkin == i)
            {
                buttons[i].GetComponent<Image>().color = Color.green;
            }
            else if(i == 0)
            {
                buttons[i].GetComponent<Image>().color = Color.blue;
            }
            else
            {
                int condition = isBoughtIntegerChange(i);
                if(condition == 0)
                {
                    buttons[i].GetComponent<Image>().color = Color.grey;
                }
                else if(condition == 1)
                {
                    buttons[i].GetComponent<Image>().color = Color.blue;
                }
            }
        }

        
    }

    public void setMoneyTextEndGame() //display current money to assigned text
    {
        money = PlayerPrefs.GetInt("money");
        endPanelMoneyText.text = money.ToString();
    }

    public void selectSkin0()
    {
        selectedSkin = 0;
        PlayerPrefs.SetInt("selectedSkin", selectedSkin);
    }

    public void checkSkinIsBought()
    {
        IsBoughtSkin1 = PlayerPrefs.GetInt("IsBoughtSkin1");
        IsBoughtSkin2 = PlayerPrefs.GetInt("IsBoughtSkin2");
        IsBoughtSkin3 = PlayerPrefs.GetInt("IsBoughtSkin3");
        IsBoughtSkin4 = PlayerPrefs.GetInt("IsBoughtSkin4");
        IsBoughtSkin5 = PlayerPrefs.GetInt("IsBoughtSkin5");
        IsBoughtSkin6 = PlayerPrefs.GetInt("IsBoughtSkin6");
        IsBoughtSkin7 = PlayerPrefs.GetInt("IsBoughtSkin7");
        IsBoughtSkin8 = PlayerPrefs.GetInt("IsBoughtSkin8");
        IsBoughtSkin9 = PlayerPrefs.GetInt("IsBoughtSkin9");
        IsBoughtSkin10 = PlayerPrefs.GetInt("IsBoughtSkin10");
        IsBoughtSkin11 = PlayerPrefs.GetInt("IsBoughtSkin11");
        IsBoughtSkin12 = PlayerPrefs.GetInt("IsBoughtSkin12");
        IsBoughtSkin13 = PlayerPrefs.GetInt("IsBoughtSkin13");
        IsBoughtSkin14 = PlayerPrefs.GetInt("IsBoughtSkin14");
        IsBoughtSkin15 = PlayerPrefs.GetInt("IsBoughtSkin15");
        IsBoughtSkin16 = PlayerPrefs.GetInt("IsBoughtSkin16");
        IsBoughtSkin17 = PlayerPrefs.GetInt("IsBoughtSkin17");
        IsBoughtSkin18 = PlayerPrefs.GetInt("IsBoughtSkin18");
        IsBoughtSkin19 = PlayerPrefs.GetInt("IsBoughtSkin19");
        IsBoughtSkin20 = PlayerPrefs.GetInt("IsBoughtSkin20");
        IsBoughtSkin21 = PlayerPrefs.GetInt("IsBoughtSkin21");
        IsBoughtSkin22 = PlayerPrefs.GetInt("IsBoughtSkin22");
        IsBoughtSkin23 = PlayerPrefs.GetInt("IsBoughtSkin23");
        IsBoughtSkin24 = PlayerPrefs.GetInt("IsBoughtSkin24");
        IsBoughtSkin25 = PlayerPrefs.GetInt("IsBoughtSkin25");
        IsBoughtSkin26 = PlayerPrefs.GetInt("IsBoughtSkin26");
        IsBoughtSkin27 = PlayerPrefs.GetInt("IsBoughtSkin27");
        IsBoughtSkin28 = PlayerPrefs.GetInt("IsBoughtSkin28");
        IsBoughtSkin29 = PlayerPrefs.GetInt("IsBoughtSkin29");
        IsBoughtSkin30 = PlayerPrefs.GetInt("IsBoughtSkin30");
        IsBoughtSkin31 = PlayerPrefs.GetInt("IsBoughtSkin31");
        IsBoughtSkin32 = PlayerPrefs.GetInt("IsBoughtSkin32");
        IsBoughtSkin33 = PlayerPrefs.GetInt("IsBoughtSkin33");
        IsBoughtSkin34 = PlayerPrefs.GetInt("IsBoughtSkin34");
        IsBoughtSkin35 = PlayerPrefs.GetInt("IsBoughtSkin35");
        IsBoughtSkin36 = PlayerPrefs.GetInt("IsBoughtSkin36");
        IsBoughtSkin37 = PlayerPrefs.GetInt("IsBoughtSkin37");
        IsBoughtSkin38 = PlayerPrefs.GetInt("IsBoughtSkin38");

        PlayerPrefs.SetInt("IsBoughtSkin1", IsBoughtSkin1);
        PlayerPrefs.SetInt("IsBoughtSkin2", IsBoughtSkin2);
        PlayerPrefs.SetInt("IsBoughtSkin3", IsBoughtSkin3);
        PlayerPrefs.SetInt("IsBoughtSkin4", IsBoughtSkin4);
        PlayerPrefs.SetInt("IsBoughtSkin5", IsBoughtSkin5);
        PlayerPrefs.SetInt("IsBoughtSkin6", IsBoughtSkin6);
        PlayerPrefs.SetInt("IsBoughtSkin7", IsBoughtSkin7);
        PlayerPrefs.SetInt("IsBoughtSkin8", IsBoughtSkin8);
        PlayerPrefs.SetInt("IsBoughtSkin9", IsBoughtSkin9);
        PlayerPrefs.SetInt("IsBoughtSkin10", IsBoughtSkin10);
        PlayerPrefs.SetInt("IsBoughtSkin11", IsBoughtSkin11);
        PlayerPrefs.SetInt("IsBoughtSkin12", IsBoughtSkin12);
        PlayerPrefs.SetInt("IsBoughtSkin13", IsBoughtSkin13);
        PlayerPrefs.SetInt("IsBoughtSkin14", IsBoughtSkin14);
        PlayerPrefs.SetInt("IsBoughtSkin15", IsBoughtSkin15);
        PlayerPrefs.SetInt("IsBoughtSkin16", IsBoughtSkin16);
        PlayerPrefs.SetInt("IsBoughtSkin17", IsBoughtSkin17);
        PlayerPrefs.SetInt("IsBoughtSkin18", IsBoughtSkin18);
        PlayerPrefs.SetInt("IsBoughtSkin19", IsBoughtSkin19);
        PlayerPrefs.SetInt("IsBoughtSkin20", IsBoughtSkin20);
        PlayerPrefs.SetInt("IsBoughtSkin21", IsBoughtSkin21);
        PlayerPrefs.SetInt("IsBoughtSkin22", IsBoughtSkin22);
        PlayerPrefs.SetInt("IsBoughtSkin23", IsBoughtSkin23);
        PlayerPrefs.SetInt("IsBoughtSkin24", IsBoughtSkin24);
        PlayerPrefs.SetInt("IsBoughtSkin25", IsBoughtSkin25);
        PlayerPrefs.SetInt("IsBoughtSkin26", IsBoughtSkin26);
        PlayerPrefs.SetInt("IsBoughtSkin27", IsBoughtSkin27);
        PlayerPrefs.SetInt("IsBoughtSkin28", IsBoughtSkin28);
        PlayerPrefs.SetInt("IsBoughtSkin29", IsBoughtSkin29);
        PlayerPrefs.SetInt("IsBoughtSkin30", IsBoughtSkin30);
        PlayerPrefs.SetInt("IsBoughtSkin31", IsBoughtSkin31);
        PlayerPrefs.SetInt("IsBoughtSkin32", IsBoughtSkin32);
        PlayerPrefs.SetInt("IsBoughtSkin33", IsBoughtSkin33);
        PlayerPrefs.SetInt("IsBoughtSkin34", IsBoughtSkin34);
        PlayerPrefs.SetInt("IsBoughtSkin35", IsBoughtSkin35);
        PlayerPrefs.SetInt("IsBoughtSkin36", IsBoughtSkin36);
        PlayerPrefs.SetInt("IsBoughtSkin37", IsBoughtSkin37);
        PlayerPrefs.SetInt("IsBoughtSkin38", IsBoughtSkin38);

        //panel1
        if (IsBoughtSkin1 == 1)
        {
            pricePanels[0].SetActive(false);
        }
        else
        {
            pricePanels[0].SetActive(true);
        }

        //panel2
        if (IsBoughtSkin2 == 1)
        {
            pricePanels[1].SetActive(false);
        }
        else
        {
            pricePanels[1].SetActive(true);
        }

        //panel3
        if (IsBoughtSkin3 == 1)
        {
            pricePanels[2].SetActive(false);
        }
        else
        {
            pricePanels[2].SetActive(true);
        }

        //panel4
        if (IsBoughtSkin4 == 1)
        {
            pricePanels[3].SetActive(false);
        }
        else
        {
            pricePanels[3].SetActive(true);
        }

        //panel5
        if (IsBoughtSkin5 == 1)
        {
            pricePanels[4].SetActive(false);
        }
        else
        {
            pricePanels[4].SetActive(true);
        }

        //panel6
        if (IsBoughtSkin6 == 1)
        {
            pricePanels[5].SetActive(false);
        }
        else
        {
            pricePanels[5].SetActive(true);
        }

        //panel7
        if (IsBoughtSkin7 == 1)
        {
            pricePanels[6].SetActive(false);
        }
        else
        {
            pricePanels[6].SetActive(true);
        }

        //panel8
        if (IsBoughtSkin8 == 1)
        {
            pricePanels[7].SetActive(false);
        }
        else
        {
            pricePanels[7].SetActive(true);
        }

        //panel9
        if (IsBoughtSkin9 == 1)
        {
            pricePanels[8].SetActive(false);
        }
        else
        {
            pricePanels[8].SetActive(true);
        }

        //panel10
        if (IsBoughtSkin10 == 1)
        {
            pricePanels[9].SetActive(false);
        }
        else
        {
            pricePanels[9].SetActive(true);
        }

        //panel11
        if (IsBoughtSkin11 == 1)
        {
            pricePanels[10].SetActive(false);
        }
        else
        {
            pricePanels[10].SetActive(true);
        }

        //panel12
        if (IsBoughtSkin12 == 1)
        {
            pricePanels[11].SetActive(false);
        }
        else
        {
            pricePanels[11].SetActive(true);
        }

        //panel13
        if (IsBoughtSkin13 == 1)
        {
            pricePanels[12].SetActive(false);
        }
        else
        {
            pricePanels[12].SetActive(true);
        }

        //panel14
        if (IsBoughtSkin14 == 1)
        {
            pricePanels[13].SetActive(false);
        }
        else
        {
            pricePanels[13].SetActive(true);
        }

        //panel15
        if (IsBoughtSkin15 == 1)
        {
            pricePanels[14].SetActive(false);
        }
        else
        {
            pricePanels[14].SetActive(true);
        }

        //panel16
        if (IsBoughtSkin16 == 1)
        {
            pricePanels[15].SetActive(false);
        }
        else
        {
            pricePanels[15].SetActive(true);
        }

        //panel17
        if (IsBoughtSkin17 == 1)
        {
            pricePanels[16].SetActive(false);
        }
        else
        {
            pricePanels[16].SetActive(true);
        }

        //panel18
        if (IsBoughtSkin18 == 1)
        {
            pricePanels[17].SetActive(false);
        }
        else
        {
            pricePanels[17].SetActive(true);
        }

        //panel19
        if (IsBoughtSkin19 == 1)
        {
            pricePanels[18].SetActive(false);
        }
        else
        {
            pricePanels[18].SetActive(true);
        }

        //panel20
        if (IsBoughtSkin20 == 1)
        {
            pricePanels[19].SetActive(false);
        }
        else
        {
            pricePanels[19].SetActive(true);
        }

        //panel21
        if (IsBoughtSkin21 == 1)
        {
            pricePanels[20].SetActive(false);
        }
        else
        {
            pricePanels[20].SetActive(true);
        }

        //panel22
        if (IsBoughtSkin22 == 1)
        {
            pricePanels[21].SetActive(false);
        }
        else
        {
            pricePanels[21].SetActive(true);
        }

        //panel23
        if (IsBoughtSkin23 == 1)
        {
            pricePanels[22].SetActive(false);
        }
        else
        {
            pricePanels[22].SetActive(true);
        }

        //panel24
        if (IsBoughtSkin24 == 1)
        {
            pricePanels[23].SetActive(false);
        }
        else
        {
            pricePanels[23].SetActive(true);
        }

        //panel25
        if (IsBoughtSkin25 == 1)
        {
            pricePanels[24].SetActive(false);
        }
        else
        {
            pricePanels[24].SetActive(true);
        }

        //panel26
        if (IsBoughtSkin26 == 1)
        {
            pricePanels[25].SetActive(false);
        }
        else
        {
            pricePanels[25].SetActive(true);
        }

        //panel27
        if (IsBoughtSkin27 == 1)
        {
            pricePanels[26].SetActive(false);
        }
        else
        {
            pricePanels[26].SetActive(true);
        }

        //panel28
        if (IsBoughtSkin28 == 1)
        {
            pricePanels[27].SetActive(false);
        }
        else
        {
            pricePanels[27].SetActive(true);
        }

        //panel29
        if (IsBoughtSkin29 == 1)
        {
            pricePanels[28].SetActive(false);
        }
        else
        {
            pricePanels[28].SetActive(true);
        }

        //panel30
        if (IsBoughtSkin30 == 1)
        {
            pricePanels[29].SetActive(false);
        }
        else
        {
            pricePanels[29].SetActive(true);
        }

        //panel31
        if (IsBoughtSkin31 == 1)
        {
            pricePanels[30].SetActive(false);
        }
        else
        {
            pricePanels[30].SetActive(true);
        }

        //panel32
        if (IsBoughtSkin32 == 1)
        {
            pricePanels[31].SetActive(false);
        }
        else
        {
            pricePanels[31].SetActive(true);
        }

        //panel33
        if (IsBoughtSkin33 == 1)
        {
            pricePanels[32].SetActive(false);
        }
        else
        {
            pricePanels[32].SetActive(true);
        }

        //panel34
        if (IsBoughtSkin34 == 1)
        {
            pricePanels[33].SetActive(false);
        }
        else
        {
            pricePanels[33].SetActive(true);
        }

        //panel35
        if (IsBoughtSkin35 == 1)
        {
            pricePanels[34].SetActive(false);
        }
        else
        {
            pricePanels[34].SetActive(true);
        }

        //panel36
        if (IsBoughtSkin36 == 1)
        {
            pricePanels[35].SetActive(false);
        }
        else
        {
            pricePanels[35].SetActive(true);
        }

        //panel37
        if (IsBoughtSkin37 == 1)
        {
            pricePanels[36].SetActive(false);
        }
        else
        {
            pricePanels[36].SetActive(true);
        }

        //panel38
        if (IsBoughtSkin38 == 1)
        {
            pricePanels[37].SetActive(false);
        }
        else
        {
            pricePanels[37].SetActive(true);
        }
    }

    //SKIN1
    public void buyOrSelectSkin1()
    {
        if(IsBoughtSkin1 == 1) //if skin is already bought, select it.
        {
            selectedSkin = 1;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        else if(money >= cost20) //cost of skin1 & if it is not bought, buy it.
        {
            money -= cost20;
            PlayerPrefs.SetInt("money", money);
            IsBoughtSkin1 = 1;
            PlayerPrefs.SetInt("IsBoughtSkin1", IsBoughtSkin1);
            selectedSkin = 1;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        //else => offer watching video to gain money
    }

    //SKIN2
    public void buyOrSelectSkin2()
    {
        if (IsBoughtSkin2 == 1) //if skin is already bought, select it.
        {
            selectedSkin = 2;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        else if (money >= cost20) //cost of skin2 & if it is not bought, buy it.
        {
            money -= cost20;
            PlayerPrefs.SetInt("money", money);
            IsBoughtSkin2 = 1;
            PlayerPrefs.SetInt("IsBoughtSkin2", IsBoughtSkin2);
            selectedSkin = 2;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        //else => offer watching video to gain money
    }

    //SKIN3
    public void buyOrSelectSkin3()
    {
        if (IsBoughtSkin3 == 1) //if skin is already bought, select it.
        {
            selectedSkin = 3;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        else if (money >= cost20) //cost of skin3 & if it is not bought, buy it.
        {
            money -= cost20;
            PlayerPrefs.SetInt("money", money);
            IsBoughtSkin3 = 1;
            PlayerPrefs.SetInt("IsBoughtSkin3", IsBoughtSkin3);
            selectedSkin = 3;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        //else => offer watching video to gain money
    }

    //SKIN4
    public void buyOrSelectSkin4()
    {
        if (IsBoughtSkin4 == 1) //if skin is already bought, select it.
        {
            selectedSkin = 4;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        else if (money >= cost20) //cost of skin4 & if it is not bought, buy it.
        {
            money -= cost20;
            PlayerPrefs.SetInt("money", money);
            IsBoughtSkin4 = 1;
            PlayerPrefs.SetInt("IsBoughtSkin4", IsBoughtSkin4);
            selectedSkin = 4;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        //else => offer watching video to gain money
    }

    //SKIN5
    public void buyOrSelectSkin5()
    {
        if (IsBoughtSkin5 == 1) //if skin is already bought, select it.
        {
            selectedSkin = 5;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        else if (money >= cost20) //cost of skin5 & if it is not bought, buy it.
        {
            money -= cost20;
            PlayerPrefs.SetInt("money", money);
            IsBoughtSkin5 = 1;
            PlayerPrefs.SetInt("IsBoughtSkin5", IsBoughtSkin5);
            selectedSkin = 5;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        //else => offer watching video to gain money
    }

    //SKIN6
    public void buyOrSelectSkin6()
    {
        if (IsBoughtSkin6 == 1) //if skin is already bought, select it.
        {
            selectedSkin = 6;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        else if (money >= cost20) //cost of skin6 & if it is not bought, buy it.
        {
            money -= cost20;
            PlayerPrefs.SetInt("money", money);
            IsBoughtSkin6 = 1;
            PlayerPrefs.SetInt("IsBoughtSkin6", IsBoughtSkin6);
            selectedSkin = 6;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        //else => offer watching video to gain money
    }

    //SKIN7
    public void buyOrSelectSkin7()
    {
        if (IsBoughtSkin7 == 1) //if skin is already bought, select it.
        {
            selectedSkin = 7;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        else if (money >= cost20) //cost of skin2 & if it is not bought, buy it.
        {
            money -= cost20;
            PlayerPrefs.SetInt("money", money);
            IsBoughtSkin7 = 1;
            PlayerPrefs.SetInt("IsBoughtSkin7", IsBoughtSkin7);
            selectedSkin = 7;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        //else => offer watching video to gain money
    }

    //SKIN8
    public void buyOrSelectSkin8()
    {
        if (IsBoughtSkin8 == 1) //if skin is already bought, select it.
        {
            selectedSkin = 8;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        else if (money >= cost20) //cost of skin8 & if it is not bought, buy it.
        {
            money -= cost20;
            PlayerPrefs.SetInt("money", money);
            IsBoughtSkin8 = 1;
            PlayerPrefs.SetInt("IsBoughtSkin8", IsBoughtSkin8);
            selectedSkin = 8;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        //else => offer watching video to gain money
    }

    //SKIN9
    public void buyOrSelectSkin9()
    {
        if (IsBoughtSkin9 == 1) //if skin is already bought, select it.
        {
            selectedSkin = 9;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        else if (money >= cost45) //cost of skin9 & if it is not bought, buy it.
        {
            money -= cost45;
            PlayerPrefs.SetInt("money", money);
            IsBoughtSkin9 = 1;
            PlayerPrefs.SetInt("IsBoughtSkin9", IsBoughtSkin9);
            selectedSkin = 9;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        //else => offer watching video to gain money
    }

    //SKIN10
    public void buyOrSelectSkin10()
    {
        if (IsBoughtSkin10 == 1) //if skin is already bought, select it.
        {
            selectedSkin = 10;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        else if (money >= cost45) //cost of skin10 & if it is not bought, buy it.
        {
            money -= cost45;
            PlayerPrefs.SetInt("money", money);
            IsBoughtSkin10 = 1;
            PlayerPrefs.SetInt("IsBoughtSkin10", IsBoughtSkin10);
            selectedSkin = 10;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        //else => offer watching video to gain money
    }

    //SKIN11
    public void buyOrSelectSkin11()
    {
        if (IsBoughtSkin11 == 1) //if skin is already bought, select it.
        {
            selectedSkin = 11;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        else if (money >= cost45) //cost of skin11 & if it is not bought, buy it.
        {
            money -= cost45;
            PlayerPrefs.SetInt("money", money);
            IsBoughtSkin11 = 1;
            PlayerPrefs.SetInt("IsBoughtSkin11", IsBoughtSkin11);
            selectedSkin = 11;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        //else => offer watching video to gain money
    }

    //SKIN12
    public void buyOrSelectSkin12()
    {
        if (IsBoughtSkin12 == 1) //if skin is already bought, select it.
        {
            selectedSkin = 12;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        else if (money >= cost45) //cost of skin12 & if it is not bought, buy it.
        {
            money -= cost45;
            PlayerPrefs.SetInt("money", money);
            IsBoughtSkin12 = 1;
            PlayerPrefs.SetInt("IsBoughtSkin12", IsBoughtSkin12);
            selectedSkin = 12;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        //else => offer watching video to gain money
    }

    //SKIN13
    public void buyOrSelectSkin13()
    {
        if (IsBoughtSkin13 == 1) //if skin is already bought, select it.
        {
            selectedSkin = 13;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        else if (money >= cost45) //cost of skin13 & if it is not bought, buy it.
        {
            money -= cost45;
            PlayerPrefs.SetInt("money", money);
            IsBoughtSkin13 = 1;
            PlayerPrefs.SetInt("IsBoughtSkin13", IsBoughtSkin13);
            selectedSkin = 13;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        //else => offer watching video to gain money
    }

    //SKIN14
    public void buyOrSelectSkin14()
    {
        if (IsBoughtSkin14 == 1) //if skin is already bought, just select it.
        {
            selectedSkin = 14;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        else if (money >= cost45) //cost of skin14 & if it is not bought, buy it.
        {
            money -= cost45;
            PlayerPrefs.SetInt("money", money);
            IsBoughtSkin14 = 1;
            PlayerPrefs.SetInt("IsBoughtSkin14", IsBoughtSkin14);
            selectedSkin = 14;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        //else => offer watching video to gain money
    }

    //SKIN15
    public void buyOrSelectSkin15()
    {
        if (IsBoughtSkin15 == 1) //if skin is already bought, select it.
        {
            selectedSkin = 15;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        else if (money >= cost45) //cost of skin15 & if it is not bought, buy it.
        {
            money -= cost45;
            PlayerPrefs.SetInt("money", money);
            IsBoughtSkin15 = 1;
            PlayerPrefs.SetInt("IsBoughtSkin15", IsBoughtSkin15);
            selectedSkin = 15;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        //else => offer watching video to gain money
    }

    //SKIN16
    public void buyOrSelectSkin16()
    {
        if (IsBoughtSkin16 == 1) //if skin is already bought, select it.
        {
            selectedSkin = 16;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        else if (money >= cost45) //cost of skin16 & if it is not bought, buy it.
        {
            money -= cost45;
            PlayerPrefs.SetInt("money", money);
            IsBoughtSkin16 = 1;
            PlayerPrefs.SetInt("IsBoughtSkin16", IsBoughtSkin16);
            selectedSkin = 16;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        //else => offer watching video to gain money
    }

    //SKIN17
    public void buyOrSelectSkin17()
    {
        if (IsBoughtSkin17 == 1) //if skin is already bought, select it.
        {
            selectedSkin = 17;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        else if (money >= cost45) //cost of skin17 & if it is not bought, buy it.
        {
            money -= cost45;
            PlayerPrefs.SetInt("money", money);
            IsBoughtSkin17 = 1;
            PlayerPrefs.SetInt("IsBoughtSkin17", IsBoughtSkin17);
            selectedSkin = 17;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        //else => offer watching video to gain money
    }

    //SKIN18
    public void buyOrSelectSkin18()
    {
        if (IsBoughtSkin18 == 1) //if skin is already bought, select it.
        {
            selectedSkin = 18;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        else if (money >= cost50) //cost of skin18 & if it is not bought, buy it.
        {
            money -= cost50;
            PlayerPrefs.SetInt("money", money);
            IsBoughtSkin18 = 1;
            PlayerPrefs.SetInt("IsBoughtSkin18", IsBoughtSkin18);
            selectedSkin = 18;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        //else => offer watching video to gain money
    }

    //SKIN19
    public void buyOrSelectSkin19()
    {
        if (IsBoughtSkin19 == 1) //if skin is already bought, select it.
        {
            selectedSkin = 19;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        else if (money >= cost50) //cost of skin19 & if it is not bought, buy it.
        {
            money -= cost50;
            PlayerPrefs.SetInt("money", money);
            IsBoughtSkin19 = 1;
            PlayerPrefs.SetInt("IsBoughtSkin19", IsBoughtSkin19);
            selectedSkin = 19;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        //else => offer watching video to gain money
    }

    //SKIN20
    public void buyOrSelectSkin20()
    {
        if (IsBoughtSkin20 == 1) //if skin is already bought, select it.
        {
            selectedSkin = 20;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        else if (money >= cost50) //cost of skin20 & if it is not bought, buy it.
        {
            money -= cost50;
            PlayerPrefs.SetInt("money", money);
            IsBoughtSkin20 = 1;
            PlayerPrefs.SetInt("IsBoughtSkin20", IsBoughtSkin20);
            selectedSkin = 20;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        //else => offer watching video to gain money
    }

    //SKIN21
    public void buyOrSelectSkin21()
    {
        if (IsBoughtSkin21 == 1) //if skin is already bought, select it.
        {
            selectedSkin = 21;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        else if (money >= cost50) //cost of skin21 & if it is not bought, buy it.
        {
            money -= cost50;
            PlayerPrefs.SetInt("money", money);
            IsBoughtSkin21 = 1;
            PlayerPrefs.SetInt("IsBoughtSkin21", IsBoughtSkin21);
            selectedSkin = 21;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        //else => offer watching video to gain money
    }

    //SKIN22
    public void buyOrSelectSkin22()
    {
        if (IsBoughtSkin22 == 1) //if skin is already bought, select it.
        {
            selectedSkin = 22;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        else if (money >= cost50) //cost of skin22 & if it is not bought, buy it.
        {
            money -= cost50;
            PlayerPrefs.SetInt("money", money);
            IsBoughtSkin22 = 1;
            PlayerPrefs.SetInt("IsBoughtSkin22", IsBoughtSkin22);
            selectedSkin = 22;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        //else => offer watching video to gain money
    }

    //SKIN23
    public void buyOrSelectSkin23()
    {
        if (IsBoughtSkin23 == 1) //if skin is already bought, select it.
        {
            selectedSkin = 23;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        else if (money >= cost50) //cost of skin23 & if it is not bought, buy it.
        {
            money -= cost50;
            PlayerPrefs.SetInt("money", money);
            IsBoughtSkin23 = 1;
            PlayerPrefs.SetInt("IsBoughtSkin23", IsBoughtSkin23);
            selectedSkin = 23;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        //else => offer watching video to gain money
    }

    //SKIN24
    public void buyOrSelectSkin24()
    {
        if (IsBoughtSkin24 == 1) //if skin is already bought, select it.
        {
            selectedSkin = 24;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        else if (money >= cost65) //cost of skin24 & if it is not bought, buy it.
        {
            money -= cost65;
            PlayerPrefs.SetInt("money", money);
            IsBoughtSkin24 = 1;
            PlayerPrefs.SetInt("IsBoughtSkin24", IsBoughtSkin24);
            selectedSkin = 24;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        //else => offer watching video to gain money
    }

    //SKIN25
    public void buyOrSelectSkin25()
    {
        if (IsBoughtSkin25 == 1) //if skin is already bought, select it.
        {
            selectedSkin = 25;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        else if (money >= cost65) //cost of skin25 & if it is not bought, buy it.
        {
            money -= cost65;
            PlayerPrefs.SetInt("money", money);
            IsBoughtSkin25 = 1;
            PlayerPrefs.SetInt("IsBoughtSkin25", IsBoughtSkin25);
            selectedSkin = 25;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        //else => offer watching video to gain money
    }

    //SKIN26
    public void buyOrSelectSkin26()
    {
        if (IsBoughtSkin26 == 1) //if skin is already bought, select it.
        {
            selectedSkin = 26;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        else if (money >= cost65) //cost of skin26 & if it is not bought, buy it.
        {
            money -= cost65;
            PlayerPrefs.SetInt("money", money);
            IsBoughtSkin26 = 1;
            PlayerPrefs.SetInt("IsBoughtSkin26", IsBoughtSkin26);
            selectedSkin = 26;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        //else => offer watching video to gain money
    }

    //SKIN27
    public void buyOrSelectSkin27()
    {
        if (IsBoughtSkin27 == 1) //if skin is already bought, select it.
        {
            selectedSkin = 27;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        else if (money >= cost65) //cost of skin27 & if it is not bought, buy it.
        {
            money -= cost65;
            PlayerPrefs.SetInt("money", money);
            IsBoughtSkin27 = 1;
            PlayerPrefs.SetInt("IsBoughtSkin27", IsBoughtSkin27);
            selectedSkin = 27;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        //else => offer watching video to gain money
    }

    //SKIN28
    public void buyOrSelectSkin28()
    {
        if (IsBoughtSkin28 == 1) //if skin is already bought, select it.
        {
            selectedSkin = 28;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        else if (money >= cost65) //cost of skin28 & if it is not bought, buy it.
        {
            money -= cost65;
            PlayerPrefs.SetInt("money", money);
            IsBoughtSkin28 = 1;
            PlayerPrefs.SetInt("IsBoughtSkin28", IsBoughtSkin28);
            selectedSkin = 28;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        //else => offer watching video to gain money
    }

    //SKIN29
    public void buyOrSelectSkin29()
    {
        if (IsBoughtSkin29 == 1) //if skin is already bought, select it.
        {
            selectedSkin = 29;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        else if (money >= cost65) //cost of skin29 & if it is not bought, buy it.
        {
            money -= cost65;
            PlayerPrefs.SetInt("money", money);
            IsBoughtSkin29 = 1;
            PlayerPrefs.SetInt("IsBoughtSkin29", IsBoughtSkin29);
            selectedSkin = 29;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        //else => offer watching video to gain money
    }

    //SKIN30
    public void buyOrSelectSkin30()
    {
        if (IsBoughtSkin30 == 1) //if skin is already bought, select it.
        {
            selectedSkin = 30;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        else if (money >= cost65) //cost of skin30 & if it is not bought, buy it.
        {
            money -= cost65;
            PlayerPrefs.SetInt("money", money);
            IsBoughtSkin30 = 1;
            PlayerPrefs.SetInt("IsBoughtSkin30", IsBoughtSkin30);
            selectedSkin = 30;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        //else => offer watching video to gain money
    }

    //SKIN31
    public void buyOrSelectSkin31()
    {
        if (IsBoughtSkin31 == 1) //if skin is already bought, select it.
        {
            selectedSkin = 31;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        else if (money >= cost65) //cost of skin31 & if it is not bought, buy it.
        {
            money -= cost65;
            PlayerPrefs.SetInt("money", money);
            IsBoughtSkin31 = 1;
            PlayerPrefs.SetInt("IsBoughtSkin31", IsBoughtSkin31);
            selectedSkin = 31;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        //else => offer watching video to gain money
    }

    //SKIN32
    public void buyOrSelectSkin32()
    {
        if (IsBoughtSkin32 == 1) //if skin is already bought, select it.
        {
            selectedSkin = 32;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        else if (money >= cost65) //cost of skin32 & if it is not bought, buy it.
        {
            money -= cost65;
            PlayerPrefs.SetInt("money", money);
            IsBoughtSkin32 = 1;
            PlayerPrefs.SetInt("IsBoughtSkin32", IsBoughtSkin32);
            selectedSkin = 32;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        //else => offer watching video to gain money
    }

    //SKIN33
    public void buyOrSelectSkin33()
    {
        if (IsBoughtSkin33 == 1) //if skin is already bought, select it.
        {
            selectedSkin = 33;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        else if (money >= cost100) //cost of skin33 & if it is not bought, buy it.
        {
            money -= cost100;
            PlayerPrefs.SetInt("money", money);
            IsBoughtSkin33 = 1;
            PlayerPrefs.SetInt("IsBoughtSkin33", IsBoughtSkin33);
            selectedSkin = 33;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        //else => offer watching video to gain money
    }

    //SKIN34
    public void buyOrSelectSkin34()
    {
        if (IsBoughtSkin34 == 1) //if skin is already bought, select it.
        {
            selectedSkin = 34;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        else if (money >= cost100) //cost of skin34 & if it is not bought, buy it.
        {
            money -= cost100;
            PlayerPrefs.SetInt("money", money);
            IsBoughtSkin34 = 1;
            PlayerPrefs.SetInt("IsBoughtSkin34", IsBoughtSkin34);
            selectedSkin = 34;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        //else => offer watching video to gain money
    }

    //SKIN35
    public void buyOrSelectSkin35()
    {
        if (IsBoughtSkin35 == 1) //if skin is already bought, select it.
        {
            selectedSkin = 35;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        else if (money >= cost100) //cost of skin35 & if it is not bought, buy it.
        {
            money -= cost100;
            PlayerPrefs.SetInt("money", money);
            IsBoughtSkin35 = 1;
            PlayerPrefs.SetInt("IsBoughtSkin35", IsBoughtSkin35);
            selectedSkin = 35;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        //else => offer watching video to gain money
    }

    //SKIN36
    public void buyOrSelectSkin36()
    {
        if (IsBoughtSkin36 == 1) //if skin is already bought, select it.
        {
            selectedSkin = 36;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        else if (money >= cost100) //cost of skin36 & if it is not bought, buy it.
        {
            money -= cost100;
            PlayerPrefs.SetInt("money", money);
            IsBoughtSkin36 = 1;
            PlayerPrefs.SetInt("IsBoughtSkin36", IsBoughtSkin36);
            selectedSkin = 36;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        //else => offer watching video to gain money
    }

    //SKIN37
    public void buyOrSelectSkin37()
    {
        if (IsBoughtSkin37 == 1) //if skin is already bought, select it.
        {
            selectedSkin = 37;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        else if (money >= cost100) //cost of skin37 & if it is not bought, buy it.
        {
            money -= cost100;
            PlayerPrefs.SetInt("money", money);
            IsBoughtSkin37 = 1;
            PlayerPrefs.SetInt("IsBoughtSkin37", IsBoughtSkin37);
            selectedSkin = 37;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        //else => offer watching video to gain money
    }

    //SKIN38
    public void buyOrSelectSkin38()
    {
        if (IsBoughtSkin38 == 1) //if skin is already bought, select it.
        {
            selectedSkin = 38;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        else if (money >= cost100) //cost of skin38 & if it is not bought, buy it.
        {
            money -= cost100;
            PlayerPrefs.SetInt("money", money);
            IsBoughtSkin38 = 1;
            PlayerPrefs.SetInt("IsBoughtSkin38", IsBoughtSkin38);
            selectedSkin = 38;
            PlayerPrefs.SetInt("selectedSkin", selectedSkin);
        }
        //else => offer watching video to gain money
    }

    public int isBoughtIntegerChange(int i)
    {
        switch(i)
        {
            case 1: return IsBoughtSkin1;
            case 2: return IsBoughtSkin2;
            case 3: return IsBoughtSkin3;
            case 4: return IsBoughtSkin4;
            case 5: return IsBoughtSkin5;
            case 6: return IsBoughtSkin6;
            case 7: return IsBoughtSkin7;
            case 8: return IsBoughtSkin8;
            case 9: return IsBoughtSkin9;
            case 10: return IsBoughtSkin10;
            case 11: return IsBoughtSkin11;
            case 12: return IsBoughtSkin12;
            case 13: return IsBoughtSkin13;
            case 14: return IsBoughtSkin14;
            case 15: return IsBoughtSkin15;
            case 16: return IsBoughtSkin16;
            case 17: return IsBoughtSkin17;
            case 18: return IsBoughtSkin18;
            case 19: return IsBoughtSkin19;
            case 20: return IsBoughtSkin20;
            case 21: return IsBoughtSkin21;
            case 22: return IsBoughtSkin22;
            case 23: return IsBoughtSkin23;
            case 24: return IsBoughtSkin24;
            case 25: return IsBoughtSkin25;
            case 26: return IsBoughtSkin26;
            case 27: return IsBoughtSkin27;
            case 28: return IsBoughtSkin28;
            case 29: return IsBoughtSkin29;
            case 30: return IsBoughtSkin30;
            case 31: return IsBoughtSkin31;
            case 32: return IsBoughtSkin32;
            case 33: return IsBoughtSkin33;
            case 34: return IsBoughtSkin34;
            case 35: return IsBoughtSkin35;
            case 36: return IsBoughtSkin36;
            case 37: return IsBoughtSkin37;
            case 38: return IsBoughtSkin38;
            default: return 0;
        }
    }
}
