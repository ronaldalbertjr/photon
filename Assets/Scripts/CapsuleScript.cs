using UnityEngine;
using System.Collections;

public class CapsuleScript : MonoBehaviour
{
    public float speed;
    public float jumpForce;

    Rigidbody rb;
    float moveW;
    float moveH;
    bool jumping;
	void Awake ()
    {
        rb = this.GetComponent<Rigidbody>();
	}
	
	void FixedUpdate ()
    {
        moveW = Input.GetAxis("Horizontal");
        moveH = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(moveW * speed, rb.velocity.y, moveH * speed);

        if(Input.GetKey(KeyCode.Space) && !jumping)
        {
            jumping = true;
            rb.AddForce(new Vector3(0, jumpForce, 0));
        }
	}

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "Terrain")
        {
            jumping = false;
        }
    }
}
