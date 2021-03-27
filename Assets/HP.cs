using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
{
    public int hitpoint = 300;
    private GameObject ScoreObject;
    public GameObject TinyExplosion;

    // Start is called before the first frame update
    void Start()
    {
        ScoreObject = GameObject.Find("TextManager");
    }

    // Update is called once per frame
    void Update()
    {
        if (hitpoint <= 0)
        {
            ScoreObject.GetComponent<TextControl>().AddScore();
            GameObject go = Instantiate(TinyExplosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

    public void Damage(int damage)
    {
        hitpoint -= damage;
        Debug.Log("hit");
    }
    
}
