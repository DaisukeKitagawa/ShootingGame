﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitychanController : MonoBehaviour
{
    private float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
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
    }
}
