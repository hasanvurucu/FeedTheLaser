using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class powerBarManager : MonoBehaviour
{
 //   public Image power;
 //   public RawImage powerBar;
 //   private float maskWidth;
 //   public RectTransform MaskRectTransform;
    public gameManager gameManagerScript;

    public Image powerBar;

    public Image levelSituation;
    public levelXPManager levelXPManagerScript;
    
    void Awake()
    {
//        MaskRectTransform = transform.Find("Mask").GetComponent<RectTransform>();
//        powerBar = transform.Find("Mask").Find("PowerBar").GetComponent<RawImage>();

      //  maskWidth = MaskRectTransform.sizeDelta.x;
    }
    
    void Update()
    {
        if (gameManagerScript.endGamePanelActive != true)
        {
            levelSituation.fillAmount = levelXPManagerScript.remainingXP / levelXPManagerScript.requiredXP;
        }
        else
        {
            levelSituation.fillAmount = 0;
        }

        powerBar.fillAmount = gameManagerScript.power / 1;

        Color newColor = new Color(1f - gameManagerScript.power, gameManagerScript.power, 0, 1);
        powerBar.color = newColor;


        /*Rect uvRect = powerBar.uvRect;
        uvRect.x -= 0.2f * Time.deltaTime;
        powerBar.uvRect = uvRect;

        Vector2 maskSizeDelta = MaskRectTransform.sizeDelta;
        maskSizeDelta.x = (gameManagerScript.power * maskWidth);
        MaskRectTransform.sizeDelta = maskSizeDelta; */
    }
}