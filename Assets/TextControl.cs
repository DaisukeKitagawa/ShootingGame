using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextControl : MonoBehaviour
{
    int Score = 0;
    public Text ScoreText;
    private GameObject clearText;
    private float span = 3.0f;
    private float delta = 0;
    public UnitychanController unitychanController;
    public EnemyGenerator enemyGenerator;

    private bool isStop = false;

    // Start is called before the first frame update
    void Start()
    {
        this.clearText = GameObject.Find("ClearText");
    }

    public void AddScore()
    {
        Score += 10;
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "SCORE:" + Score.ToString();
        if(Score >= 100)
        {
            if(!isStop)
            {
                isStop = true;
                unitychanController.enabled = false;
                enemyGenerator.enabled = false;
            }
            this.delta += Time.deltaTime;
            this.clearText.GetComponent<Text>().text = "CLEAR";
            if(this.delta > this.span)
            {
                Debug.Log(this.delta);
                SceneManager.LoadScene("TitleScene");
            }
        }
    }
}
