using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/* 점수 증감에 관련된 스크립트 */
public class Score : MonoBehaviour
{
    float score = 0.0f;
    float difficultyBonus = 1.0f;
    int solvedQuestion = 0;

    public Text SolvedProbelm;
    public Text FinalScore;

    private void Start()
    {
        Reset();
    }

    public void IncreaseScore()
    {
        solvedQuestion++;
        score += 10 * difficultyBonus;
        if (solvedQuestion % 5 == 0)
        {
            difficultyBonus += 0.1f;
        }
    }

    public void PrintSocreAtText()
    {
        SolvedProbelm.text = solvedQuestion.ToString();
        FinalScore.text = Mathf.RoundToInt(score).ToString();
    }

    public void Reset()
    {
        score = 0.0f;
        difficultyBonus = 1.0f;
        solvedQuestion = 0;
    }
}
