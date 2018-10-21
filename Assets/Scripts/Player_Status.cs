using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player_Status : MonoBehaviour {

    private bool isAlive;
    public Text gameOver;
    public GameObject PlayerDeathEffect;
 

    // Use this for initialization
    void Start () {
        isAlive = true;
	}
	
	// Update is called once per frame
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

    IEnumerator Death()
    {
        gameOver.text = "Game Over";
        // Instantiate(PlayerDeathEffect, transform.position, Quaternion.identity);

        yield return new WaitForSeconds(2);
        Destroy(gameObject);
        SceneManager.LoadScene("EECS268");
        
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "Enemy")
        {
            isAlive = false;
        }
    }

}
