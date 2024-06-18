using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickButton : MonoBehaviour
{
    public GameManager GM;

    public void OnClick()
    {
        GM.score++;
    }
}
