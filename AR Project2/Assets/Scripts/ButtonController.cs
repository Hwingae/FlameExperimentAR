using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public GameObject StartUI;
    public GameObject GameUI;
    public GameObject GameOverUI;

    private void Start()
    {
        StartUI.SetActive(true);
    }

    public void GameStartButton()
    {
        StartUI.SetActive(false);
        GameUI.SetActive(true);
    }

    public void RestartButton()
    {
        GameOverUI.SetActive(false);
        GameUI.SetActive(true);
    }
}
