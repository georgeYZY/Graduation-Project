using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newjoystickplayercontroller : MonoBehaviour
{
    
    private float movementSpeed = 500.0f;
    private Vector2 movement;
    private Animator animator;
    public Joystick joystick;
    void Start()
    {
        
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        movement = new Vector2(joystick.Horizontal,joystick.Vertical).normalized;
        animator.SetFloat("Speed",Mathf.Abs(movement.magnitude * movementSpeed));

        bool flipped = movement.x<0;
        this.transform.rotation = Quaternion.Euler(new Vector3(0f,flipped ? 180f: 0f, 0f));
    }
    private void FixedUpdate()
    {
        if(movement != Vector2.zero)
        {
            var xMovement = movement.x*movementSpeed * Time.fixedDeltaTime;
            this.transform.Translate(new Vector3(xMovement,0),Space.World);
        }
    }
}