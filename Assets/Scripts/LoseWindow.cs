using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class LoseWindow : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI bestScoreTXT;
    public Medal[] medals;
    public Image medalDisplay;

    public void PlayerLose(){
        int score = ScoreManager.instance.score;
        scoreText.text = score.ToString();
        int bestScore = PlayerPrefs.GetInt("BestScore"); //PlayerPrefs - на время игровой сессии
        if(score > bestScore){
            bestScore = score;
        }

        for(int i=0; i<medals.Length; i++){
            if(medals[i].ScoreNeed <= score){
                medalDisplay.gameObject.SetActive(true);
                medalDisplay.sprite = medals[i].MedalSprite;
            }
        }

        bestScoreTXT.text = bestScore.ToString();
        PlayerPrefs.SetInt("BestScore", bestScore);
    }
}
