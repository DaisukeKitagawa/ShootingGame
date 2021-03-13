using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
{
    public int hitpoint = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hitpoint <= 0)
        {
           Destroy(gameObject);
        }
    }

    public void Damage(int damage)
    {
        hitpoint -= damage;
        Debug.Log("hit");
    }
    
}
