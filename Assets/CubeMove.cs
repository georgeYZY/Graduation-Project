using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveX;
    private float moveY;
    public float speed;
    public Joystick joystick;

    bool facingRiht = true;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveX = joystick.Horizontal;
        moveY = joystick.Vertical;
        rb.velocity = new Vector2(moveX*speed*Time.deltaTime,moveY*speed*Time.deltaTime);
    }
    void FixedUpdate(){
        if(moveX>0 && !facingRiht){
            Flip();
        }else if(moveX < 0 && facingRiht)
        {
             Flip();
        }
    }
    void Flip(){
        facingRiht = !facingRiht;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
