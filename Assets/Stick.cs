using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stick : MonoBehaviour
{
    public GameObject unitychan;
    [SerializeField] Joystick joystick = null;

    // Start is called before the first frame update
    void Start()
    {
        float horizontal = joystick.Horizontal;
        float vertical = joystick.Vertical;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
