using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSuite : MonoBehaviour {

    public Rigidbody2D user;

    void Start()
    {
        DontDestroyOnLoad(this);
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
        if (GameManager.testmode == true)
        {
            Debug.Log("test");
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
    void MoveLeftTest()
    {
        user.transform.position += new Vector3(-20, 0, 0);
        Debug.Log("MOVE LEFT PASS");

    }
    void MoveRightTest()
    {
        user.transform.position += new Vector3(20, 0, 0);
        Debug.Log("MOVE RIGHT PASS");
    }
}
