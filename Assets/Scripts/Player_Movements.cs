using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movements : MonoBehaviour {

    public int speed = 10;
    private bool facingRight = false;
    public int jumpPower = 1200;
    private bool isGround;
    private float moveKey;
    private bool freeze = false;
	
	// Update is called once per frame
	void Update () {
        PlayerMove();
    }

    void PlayerMove()
    {
        if(freeze == false)
        {
            //control
            moveKey = Input.GetAxis("Horizontal");
            if (Input.GetButtonDown("Jump") && isGround == true)
            { Jump(); }
            //player direction
            if (moveKey < 0.0f && facingRight == false)
            { Flip(); }
            else if (moveKey > 0.0f && facingRight == true)
            { Flip(); }

            //Physic
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveKey * speed, gameObject.GetComponent<Rigidbody2D>().velocity.y);

        }
        else
        {
            Debug.Log("Freeze");
        }

    }

    void Flip()
    {
        facingRight = !facingRight;
        transform.Rotate(0f, 180f, 0f);
    }

    void Jump()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpPower);
        isGround = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            isGround = true;
        }
        if (collision.gameObject.tag == "Enemy")
        {
            freeze = true;
        }
        if (collision.gameObject.tag == "Hole")
        {
            freeze = true;
        }
    }

   
}
