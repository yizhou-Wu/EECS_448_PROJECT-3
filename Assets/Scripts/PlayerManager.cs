/** 
 * @author Team FourFour8
 * @file PlayerManager.cs
 * @date October 2018
 * @brief PlayerManager class. This class takes charge of the properties of the Player.
**/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour {

    // Update is called once per frame
    public static float Movespeed;// The move speed of the charater.
    public static float GPA;// The global 
    float i = 1;// Counter that prevent the user to move multiple times.
    //private static bool playerExist;// Flag to check whether the player is existing on current screnn;
    public static float Health=30f;
    public static float Money=50f;
    //private bool GameHasEnded = f;
    /**
    * @pre None.
    * @post Keep the GameObject player when change the scene because unity destroy eveything on current scene after change scenes.
    * @para None.
    **/
    void Start()
    {
        if (GameManager.GameHasEnded == true)
        {
            Health = 100f;
            Money = 50f;
            GameManager.GameHasEnded = false;
        }
        DontDestroyOnLoad(this);
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
    }
    /**
    * @pre None.
    * @post Allow the user to control the player object with left and right arrow keys.
    * @para None.
    **/
    void Update ()
    {
        if (i >= 1)
        {
            if (Input.GetKey(KeyCode.RightArrow))//Move right.
            {
                gameObject.transform.position += new Vector3(20, 0, 0);//20 is the distance from one block to anouther.
                Health -= 10;
                i = 0;//Reset the time counter.
            }
            if (Input.GetKey(KeyCode.LeftArrow))//Move left.
            {
                gameObject.transform.position += new Vector3(-20, 0, 0);
                Health -= 10;
                i = 0;
            }
            
        }
        i += Time.deltaTime;//Counter increase.
        if(Health<10)
        {
            GameManager.GameHasEnded = true;
            FindObjectOfType<GameManager>().EndGame();
            enabled = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log(GameManager.GameHasEnded);
        if (GameManager.GameHasEnded == false)
        {
            if (collision.gameObject.tag == "Midterm")
            {
                SceneManager.LoadScene("Midterm");
                collision.isTrigger = false;//Turn off the trigger so that the user cannot go back.
            }
            else if (collision.gameObject.tag == "Tic")
            {
                SceneManager.LoadScene("Tic");
                collision.isTrigger = false;
            }
            else if (collision.gameObject.tag == "TEST")
            {
                SceneManager.LoadScene("randomE1");
                collision.isTrigger = false;
            }
            else if (collision.gameObject.tag == "ShotGame")
            {
                SceneManager.LoadScene("EECS268");
                collision.isTrigger = false;
                gameObject.SetActive(false);
            }
            else if (collision.gameObject.tag=="RE")
            {
                int levelnum=Random.Range(6, 9);
                SceneManager.LoadScene(levelnum);
            }
        }
    }
}
