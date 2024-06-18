using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ShopButton : MonoBehaviour
{
    public GameManager GM;

    public Text shopText;

    public void ShopClick()
    {
        GM.shop++;
        shopText.text = "자동 클릭 LV." + GM.shop.ToString();
    }
}
