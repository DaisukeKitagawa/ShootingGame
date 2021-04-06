using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stick : MonoBehaviour
{
    public GameObject unitychan;
    private float speed = 7f;
    [SerializeField] DynamicJoystick dynamicjoystick = null;

    // Start is called before the first frame update
    void Start()
    {
        float horizontal = dynamicjoystick.Horizontal;
        float vertical = dynamicjoystick.Vertical;
        Vector2 direction = dynamicjoystick.Direction;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = dynamicjoystick.Horizontal;
        if(horizontal < 0)
        {
            unitychan.transform.Rotate(0, -speed, 0);
        }

        if(horizontal > 0)
        {
            unitychan.transform.Rotate(0, speed, 0);
        }
    }
}
