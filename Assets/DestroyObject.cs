using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public int damage;
    private GameObject enemy;
    private HP hp;
    // Start is called before the first frame update
    void Start()
    {
        enemy = GameObject.Find("EnemyPrefab");
        hp = gameObject.GetComponent<HP>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter : "+other.gameObject.tag);
        if(other.gameObject.CompareTag("bulletPrefab"))
        {
            hp.Damage(damage);

            Destroy(other.gameObject);
        }
    }
}
