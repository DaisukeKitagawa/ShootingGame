using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject EnemyPrefab;

    private float delta = 0;

    private float span = 3.0f;

    private int maxEnemyNum = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;

        if( this.delta > this.span )
        {
            this.delta = 0;

            GameObject go = Instantiate(EnemyPrefab) as GameObject;

            EnemyPrefab.transform.position = new Vector3(
                                             Random.Range(-14, 14),
                                             0,
                                             Random.Range(-14, 14)
                                             );
        }
    }
}
