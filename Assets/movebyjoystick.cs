using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movebyjoystick : MonoBehaviour
{
     // public CharacterController2D controller;
    // public Animator animator;
    Rigidbody2D rb;
    private Animator anim;

    public Joystick joystick;

    // public float runSpeed = 40f;
    public float speed;

    //float horizontalMove = 0f;
    private Vector2 moveVelocity;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // horizontalMove = joystick.Horizontal*runSpeed;
        // anim.SetFloat("Speed",Mathf.Abs(horizontalMove));
                
        Vector2 moveInput = new Vector2(joystick.Horizontal,joystick.Vertical);
        moveVelocity = moveInput * speed * Time.deltaTime;

        
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position+moveVelocity * Time.fixedDeltaTime);
        
    }
}
