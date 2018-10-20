using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class eventtrigger : MonoBehaviour {
    //public GameObject player;
    //public string Nextlevel;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Finish")
        {
            Debug.Log("1111");
            SceneManager.LoadScene("Midterm");
            Debug.Log("2222");
            collision.isTrigger = false;
        }
        else if(collision.gameObject.tag == "1")
        {
            SceneManager.LoadScene("test");
            Debug.Log("3333");
            collision.isTrigger = false;
        }
    }
}
