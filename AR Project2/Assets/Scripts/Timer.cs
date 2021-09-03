using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.UI;

/* 게임의 타이머 + UI에 대한 스크립트입니다. */
public class Timer : MonoBehaviour
{
    private float curTime = 0.0f;
    public float maxTime = 30.0f;

    public Slider slider;
    public Score scoreScript;
    public GameObject GamePlayUI;
    public GameObject GameOverUI;

    bool timerOn = false;

    const float minusTimeValue = 0.94f;

    private void Update()
    {
        if (timerOn) { TimeGoes(); }
    }

    public void StartRound() //게임의 라운드를 시작합니다. UI버튼과 연결됩니다.
    {
        slider.maxValue = maxTime;
        slider.value = slider.maxValue;
        curTime = 0;
        timerOn = true;
    }

    public void NextRound() //다음 라운드로 진입합니다. FireColorChanger와 연결됩니다.
    {
        curTime = 0;
        maxTime = maxTime * minusTimeValue;
        slider.maxValue = maxTime;
        slider.value = slider.maxValue;

        scoreScript.IncreaseScore();
    }

    public void TimeGoes() //타이머...
    {
        curTime += Time.deltaTime;
        slider.value = maxTime - curTime;

        if (curTime >= maxTime)
        {
            timerOn = false;
            scoreScript.PrintSocreAtText();
            GamePlayUI.SetActive(false);
            GameOverUI.SetActive(true);
            scoreScript.Reset();
        }
    }
}
