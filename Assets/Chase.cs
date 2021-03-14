using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Chase : MonoBehaviour
{
    private NavMeshAgent agent;
    private GameObject unitychan;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        this.unitychan = GameObject.Find("unitychan");
    }

    // Update is called once per frame
    void Update()
    {
        if(agent.pathStatus != NavMeshPathStatus.PathInvalid)
        {
            agent.destination = unitychan.transform.position;
        }
    }
}
