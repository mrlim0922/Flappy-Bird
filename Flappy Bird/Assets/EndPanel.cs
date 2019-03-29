using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndPanel : MonoBehaviour
{
    public Text ScoreText;
    public Text BestScoreText;

    public GameObject NewImage;

    public GameObject Medal;

    public Sprite GoldMedal;
    public Sprite SilverMedal;
    public Sprite BronzeMedal;

    void OnEnable()
    {
        //베스트 스코어 갱신.
        if (GameManager.score > GameManager.BestScore)
        {
            GameManager.BestScore = GameManager.score;
            NewImage.SetActive(true);

        } else
        {
            NewImage.SetActive(false);
        }

        //스코어, 베스트스코어 출력.
        ScoreText.text = GameManager.score.ToString();
        BestScoreText.text = GameManager.BestScore.ToString();

        if (GameManager.score >= 20)
        {
            Medal.GetComponent<Image>().sprite = GoldMedal;
        }
        else if (GameManager.score >= 10)
        {
            Medal.GetComponent<Image>().sprite = SilverMedal;
        }
        else
        {
            Medal.GetComponent<Image>().sprite = BronzeMedal;
        }
    }


}
