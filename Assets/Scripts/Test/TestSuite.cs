/** 
 * @author Team FourFour8
 * @file TestSuite.cs
 * @date Nov 2018
 * @brief MidtermTest class. This class takes charge of the properties of the TestSuite.
**/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSuite : MonoBehaviour {

    public Rigidbody2D user;

    /**
    * @pre None.
    * @post Run the functions automaticlly.
    * @para None.   
    **/
    void Start()
    {
        DontDestroyOnLoad(this);
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
        if (GameManager.testmode == true)
        {
            //Debug.Log("test");
            Invoke("MoveRightTest", 1);
            Invoke("MoveLeftTest", 3);
            Invoke("MoveRightTest", 5);
            Invoke("MoveRightTest", 7);
            Invoke("MoveRightTest", 9);
            Invoke("MoveRightTest", 11);
            Invoke("MoveRightTest", 13);
            Invoke("MoveRightTest", 15);
            Invoke("MoveRightTest", 17);
            Invoke("MoveRightTest", 19);
            //Debug.Log("Test finish");
        }

    }
    /**
    * @pre None.
    * @post Simulate the move function in the playermanager
    * @para None.   
    **/
    void MoveLeftTest()
    {
        user.transform.position += new Vector3(-20, 0, 0);
        PlayerManager.Health -= 10;
        Debug.Log("MOVE LEFT PASS");

    }
    /**
    * @pre None.
    * @post Simulate the move function in the playermanager
    * @para None.   
    **/
    void MoveRightTest()
    {
        user.transform.position += new Vector3(20, 0, 0);
        PlayerManager.Health -= 10;
        Debug.Log("MOVE RIGHT PASS");
    }
}
