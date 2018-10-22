/**
 * @author Team FourFour8
 * @file Player_Status.cs
 * @date 10/2018
 * @brief logic for player status
 **/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
/**
 * definition of enemy's health status
**/
public class Player_Status : MonoBehaviour {

    private bool isAlive;
    public Text gameOver;
    public GameObject PlayerDeathEffect;

    /**
     * used for initialization
     * @pre none
     * @post isShot is true and velocity changes
     * @return void
     **/
    void Start () {
        isAlive = true;
	}

    /**
   * update is called once per frame
   * @pre none
   * @post updated frame
   * @return void
   **/
    void Update () {
		if(gameObject.transform.position.y < -7)
        {
            isAlive = false;

        }
        
        if(isAlive == false)
        {
            StartCoroutine("Death");
        }
	}
    /**
    * logic for post-death event
    * @pre player dies
    * @post quit or back to beginning of game
    * @return void
    **/
    IEnumerator Death()
    {
        gameOver.text = "Game Over";
        // Instantiate(PlayerDeathEffect, transform.position, Quaternion.identity);

        yield return new WaitForSeconds(2);
        Destroy(gameObject);
        SceneManager.LoadScene("EECS268");
        
        
    }
    /**
   * defines collison of player with enemy
   * @pre collision occurs
   * @post player dies
   * @param collison is a Collider2D object
   * @return void
   **/
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "Enemy")
        {
            isAlive = false;
        }
    }

}
