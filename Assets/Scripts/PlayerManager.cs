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

public class PlayerManager : MonoBehaviour
{

    // Update is called once per frame
    public static float Movespeed;// The move speed of the charater.
    public static float GPA;// The global 
    float i = 1;// Counter that prevent the user to move multiple times.
    //private static bool playerExist;// Flag to check whether the player is existing on current screnn;
    public static float Health = 100f;
    public static float Money = 100f;
    public static bool AllowUse = true;
    public static string userName;
    //private bool GameHasEnded = f;
    /**
    * @pre None.
    * @post Keep the GameObject player when change the scene because unity destroy eveything on current scene after change scenes.
    * @para None.
    **/
    void Start()
    {

        
        //gameObject.SetActive(true);
        if (GameManager.GameHasEnded == true)
        {
            Health = 80f;
            Money = 50f;
            GPA = 0.0f;
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
    void Update()
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
        if (Health < 10)
        {
            GameManager.GameHasEnded = true;
            FindObjectOfType<GameManager>().EndGame();
            //SceneManager.LoadScene("gamefinish");
            gameObject.SetActive(false);
            enabled = false;
        }
    }
    /**
    * @pre None.
    * @post Load scenes depending on the tag of the collision.
    * @para None.   
    **/
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("1111");
        Debug.Log(AllowUse);
        if (GameManager.GameHasEnded == false&&AllowUse==true)
        {

            if (collision.gameObject.tag == "Midterm")
            {
                //gameObject.SetActive(false);
                AllowUse = false;
                SceneManager.LoadScene("Midterm");
                collision.isTrigger = false;//Turn off the trigger so that the user cannot go back.

            }
            else if (collision.gameObject.tag == "Tic")
            {
                //gameObject.SetActive(false);
                AllowUse = false;
                SceneManager.LoadScene("Tic");
                collision.isTrigger = false;
           
            }
            else if (collision.gameObject.tag == "Final")
            {
                //gameObject.SetActive(false);
                AllowUse = false;
                SceneManager.LoadScene("Final");
                collision.isTrigger = false;
            }
            else if (collision.gameObject.tag == "Shop")
            {
                //gameObject.SetActive(false);
                AllowUse = false;
                SceneManager.LoadScene("Shop");
                collision.isTrigger = false;
            }
            else if (collision.gameObject.tag == "ShotGame")
            {
                foreach (GameObject o in Object.FindObjectsOfType<GameObject>())
                {
                    Destroy(o);
                }
                AllowUse = false;
                SceneManager.LoadScene("EECS268");
                collision.isTrigger = false;
            }
            else if (collision.gameObject.tag == "RE")
            {
                //gameObject.SetActive(false);
                AllowUse = false;
                collision.isTrigger = false;
                int levelnum = Random.Range(7, 10);
                SceneManager.LoadScene(levelnum);
            }
        }
    }
}