/**
 * @author Team FourFour8
 * @file Player_Movements.cs
 * @date 10/2018
 * @brief logic for player moving
 **/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * definition of player movements and potential enemy interaction
**/
public class Player_Movements : MonoBehaviour {

    public int speed = 10;
    private bool facingRight = false;
    public int jumpPower = 1200;
    private bool isGround;
    private float moveKey;
    private bool freeze = false;

    /**
   * update is called once per frame
   * @pre none
   * @post updated frame
   * @return void
   **/
    void Update () {
        PlayerMove();
    }
    /**
   * defines how the player moves
   * @pre none
   * @post moved to desired location
   * @return void
   **/
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
    /**
     * called with PlayerMove() and allows for direction change
     * @pre none
     * @post flipped direction
     * @return void
     **/
    void Flip()
    {
        facingRight = !facingRight;
        transform.Rotate(0f, 180f, 0f);
    }
    /**
   * defines how a player jump works
   * @pre none
   * @post player jumps
   * @return void
   **/
    void Jump()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpPower);
        isGround = false;
    }
    /**
 * defines collison of player with any object
 * @pre player collides with something
 * @post player can die, or remain fine depending on collision type
 * @param collison is a Collider2D object
 * @return void
 **/
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground" || collision.gameObject.tag == "Wall2")
        {
            isGround = true;
        }
        if (collision.gameObject.tag == "Enemy")
        {
            freeze = true;
        }
        
    }

   
}
