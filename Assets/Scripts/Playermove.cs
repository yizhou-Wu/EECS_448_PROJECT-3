using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermove : MonoBehaviour {

    // Update is called once per frame
    public static float Movespeed;// The move speed of the charater.
    public static float GPA;
    float i = 1;// Counter that prevent the user to move multiple times.
    private static bool playerExist;// Flag to check whether the player is existing on current screnn;
    private void Start()
    {
        Debug.Log(GPA);
        if(!playerExist)
        {
            playerExist = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        Debug.Log(GPA);


    }
    void Update ()
    {
        if (i >= 1)
        {
            if (Input.GetKey(KeyCode.RightArrow))//Move right.
            {
                gameObject.transform.position += new Vector3(20, 0, 0);//-20 is the distance from one block to anouther.
                i = 0;//Reset the time counter.
            }
            if (Input.GetKey(KeyCode.LeftArrow))//Move left.
            {
                gameObject.transform.position += new Vector3(-20, 0, 0);
                i = 0;
            }
            
        }
        i += Time.deltaTime;//Counter increase.
    }
}
