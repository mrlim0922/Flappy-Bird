using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    static public bool playerDie = false;
    public float pipeTime = 2f;
    public float pipeMin = -1f;
    public float pipeMax = 1f;

    static public int score = 0;
    static public int BestScore = 0;

    public GameObject PipePrefab;
    public Text ScoreText;
    public GameObject StartPanel;

    void Start()
    {
        Time.timeScale = 0;
        GameManager.playerDie = true;
    }

    IEnumerator PipeStart()
    {
        do
        {
            Instantiate(PipePrefab, new Vector3(2, Random.Range(pipeMin, pipeMax), 0), Quaternion.Euler(new Vector3 (0, 0, 0)));   //파이프 생성.

            yield return new WaitForSeconds(pipeTime);


        } while (playerDie == false);
    }

    void Update()
    {
        ScoreText.text = score.ToString();
    }

    public void StartButton()
    {
        GameManager.playerDie = false;
        StartPanel.SetActive(false);
        StartCoroutine(PipeStart());
        Time.timeScale = 1;
    }

    public void ReStart_Button()
    {
        GameManager.playerDie = false;
        GameManager.score = 0;
        SceneManager.LoadScene("play");
    }
}