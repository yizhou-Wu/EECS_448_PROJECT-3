/**
 * @author Team FourFour8
 * @file Enimies_Movement.cs
 * @date 10/2018
 * @brief logic for enemy movements
 **/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * definition of enemy movements and potential player interaction
**/
public class Enimies_Movement : MonoBehaviour {

    public int Speed = 4;
    public int Direction = -1;
    private bool Efreeze;
    

    /**
     * update is called once per frame
     * @pre none
     * @post none
     * @return void
     **/
    void Update () {
        if(Efreeze == false)
        { 
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(Direction, 0) * Speed;
            Debug.Log("Freeze");
        }
        
	}
    /**
     * called with update and allows for direction change
     * @pre none
     * @post possible direction change
     * @return void
     **/
    void Flip()
    {
        if(Direction > 0)
        {
            Direction = -1;
        }
        else
        {
            Direction = 1;
        }
    }
    /**
     * defines collison of olayer with enemy
     * @pre player hits something
     * @post if it collides with player, player dies
     * @param collison is a Collider2D object
     * @return void
     **/
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag =="Wall2" || collision.gameObject.tag == "Enemy")
        {
            Flip();
        }
        

        if (collision.gameObject.tag == "Player")
        {
            Efreeze = true;
        }
    }
}
