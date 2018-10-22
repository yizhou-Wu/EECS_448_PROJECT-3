using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Eventtrigger : MonoBehaviour
{
    /**
    * @pre An existing GameObject player.
    * @post Load the scene depending on the collision tag.
    * @para The objects that collide.
    **/
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Midterm")
        {
            SceneManager.LoadScene("Midterm");
            collision.isTrigger = false;//Turn off the trigger so that the user cannot go back.
        }
        else if(collision.gameObject.tag == "Stage")
        {
            SceneManager.LoadScene("test");
            collision.isTrigger = false;
        }
    }
}
