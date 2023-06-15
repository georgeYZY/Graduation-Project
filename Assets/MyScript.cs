using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{

    public Joystick joystick;
    float HorizontalMove = 0f;


    // use this for initialization
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
  
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalMove = joystick.Horizontal;

        // var rigidbody = GetComponent<Rigidbody>();

        // rigidbody.velocity = new Vector3(joystick.Horizontal * 100f,
        //                                  rigidbody.velocity.y,
        //                                  joystick.Vertical * 100f); 



    }
}