using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UnitychanController : MonoBehaviour
{
    private float speed = 7f;
    private int hp = 1000;
    private bool damage = false;
    private GameObject hpText;
    private GameObject gameoverText;
    private float delta = 0;
    private float span = 3.0f;
    public EnemyGenerator enemyGenerator;

    private bool isStop = false;

    // Start is called before the first frame update
    void Start()
    {
        this.hpText = GameObject.Find("HPText");
        this.gameoverText = GameObject.Find("GameOverText");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey (KeyCode.LeftArrow))
        {
            transform.Rotate(0, -speed, 0);
        }

        else if (Input.GetKey (KeyCode.RightArrow))
        {
            transform.Rotate(0, speed, 0);
        }

        if (this.damage)
        {
            Debug.Log("-100");
            this.hp -= 100;
            this.damage = false;
            this.hpText.GetComponent<Text> ().text = "HP :" + this.hp;
        }

        if(this.hp <= 0)
        {
            if(!isStop)
            {
                isStop = true;
                enemyGenerator.enabled = false;
            }
            this.delta += Time.deltaTime;
            this.gameoverText.GetComponent<Text>().text = "GameOver";
            if(this.delta > this.span)
            {
                SceneManager.LoadScene("TitleScene");
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "EnemyPrefab")
        {
            Debug.Log("DAMAGE");
            this.damage = true;
        }
    }
}
