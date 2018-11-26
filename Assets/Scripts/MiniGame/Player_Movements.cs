/**
 * @author Team FourFour8
 * @file Player_Movements.cs
 * @date 10/2018
 * @brief logic for player moving
 **/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
/**
 * definition of player movements and potential enemy interaction
**/
public class Player_Movements : MonoBehaviour
{



    private int speed = 10;
    private bool facingRight = false;
    private int jumpPower = 1500;
    private bool isGround;
    private float moveKey;
    private bool freeze = false;
    public Animator animator;
    float horizontalMove;
    public Transform fireStart;
    public GameObject bulletPrep;
    private int frame = 1;
    private bool isMoveLeft, isMoveRight, isJumpTest, isShot = false;
    public Button back;


    /**
   * update is called once per frame
   * @pre none
   * @post updated frame
   * @return void
   **/
    void Update()
    {
			if(GameManager.testmode == true)
			{
				StartCoroutine("WaitForNextStep");
				PlayerMove();
			}
			else
			{
            moveKey = Input.GetAxis("Horizontal");
            PlayerMove();
			}
    }

    /**
   * Run all the test simulations
   * @pre none
   * @post updated frame
   * @return void
   **/
    IEnumerator WaitForNextStep()
    {
        if (isMoveLeft == false)
        {
            Debug.Log("TEST 3: PLAYER MOVE LEFT PASSED");
            moveKey = -0.3f;
            isMoveLeft = true;
        }
        yield return new WaitForSeconds(2);
        if (isMoveRight == false)
        {
            Debug.Log("TEST 4: PLAYER MOVE RIGHT PASSED");
            moveKey = 0.3f;
            isMoveRight = true;
        }
        yield return new WaitForSeconds(2);
        if (isShot == false)
        {
            Debug.Log("TEST 16: PLAYER SHOOT PASSED");
            moveKey = 0.0f;
            Shoot();
            Shoot();
            Shoot();
            isShot = true;
        }
        yield return new WaitForSeconds(2);
        if (isJumpTest == false)
        {
            Debug.Log("TEST 5: PLAYER JUMPS PASSED");
            Jump();
            isJumpTest = true;
        }

        moveKey = 0.5f;
        yield return new WaitForSeconds(2);
        back.onClick.Invoke();

        yield return null;


    }
    /**
   * defines how the player moves
   * @pre none
   * @post moved to desired location
   * @return void
   **/
    void PlayerMove()
    {
        if (freeze == false)
        {
            horizontalMove = Input.GetAxisRaw("Horizontal") * speed;
            animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

            //control
            //moveKey = Input.GetAxis("Horizontal");

            if (Input.GetButtonDown("Jump") && isGround == true)
            {
                Jump();

            }
            //player direction
            if (moveKey < 0.0f && facingRight == false)
            {

                Flip();
            }
            else if (moveKey > 0.0f && facingRight == true)
            {

                Flip();
            }

            if (Input.GetButtonDown("Fire2"))
            {
                Shoot();
                animator.SetBool("isShot", true);
            }
            if (Input.GetButtonUp("Fire2"))
            {

                animator.SetBool("isShot", false);
            }

            //Physic
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveKey * speed, gameObject.GetComponent<Rigidbody2D>().velocity.y);

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
        transform.Rotate(0f, -180f, 0f);
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
        animator.SetBool("isJump", true);
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
        if (collision.gameObject.tag == "Ground" || collision.gameObject.tag == "Wall2")
        {
            Debug.Log("TEST 6: PLAYER STANDS ON GROUND/WALL PASSED");
            isGround = true;
            animator.SetBool("isJump", false);
        }
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("TEST 6: PLAYER HITS AN ENEMY PASSED");
            freeze = true;
        }

    }

    void Shoot()
    {
        Instantiate(bulletPrep, fireStart.position, fireStart.rotation);
    }

}
