using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityStandardAssets.CrossPlatformInput;

public class movecontroll : MonoBehaviour
{
    Rigidbody2D myRigidBody;
    [SerializeField] float mySpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Run();
        FlipCharacter();
    }
    private void Run(){
        /*float controlThrowX = CrossPlatformInputManager.GetAxis("Horizontal");
        float controlThrowY = CrossPlatformInputManager.GetAxis("Vertical");
        Vector2 playerVelocity = new Vector2(controlThrowX*mySpeed,controlThrowY*mySpeed);
        myRigidBody.velocity = playerVelocity;*/
    }
    private void FlipCharacter(){
        bool playIsMoving = Mathf.Abs(myRigidBody.velocity.x)>0f;
        if(playIsMoving){
            transform.localScale = new Vector2(Mathf.Sign(myRigidBody.velocity.x)*1f,1f);
        }
    }
}
