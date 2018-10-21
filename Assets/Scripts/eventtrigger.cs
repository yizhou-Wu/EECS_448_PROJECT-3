using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Eventtrigger : MonoBehaviour {
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Midterm")
        {
            SceneManager.LoadScene("Midterm");
            collision.isTrigger = false;
        }
        else if(collision.gameObject.tag == "Stage")
        {
            SceneManager.LoadScene("test");
            collision.isTrigger = false;
        }
    }
}
