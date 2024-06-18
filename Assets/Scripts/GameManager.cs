using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int score = 0;
    public int shop = 0;
    public Text scoreText;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    private void Start()
    {
        StartCoroutine("AutoClick");
    }

    private void Update()
    {
        scoreText.text = score.ToString();
    }

    IEnumerator AutoClick()
    {
        while (true)
        {
            score += shop;
            yield return new WaitForSecondsRealtime(1.0f);
        }
    }
}
