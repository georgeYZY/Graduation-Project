using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
   
    public float speed;

    private Vector2 moveVelocity;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"),0);
        moveVelocity = moveInput * speed;
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position+moveVelocity * Time.fixedDeltaTime);
    }
}
