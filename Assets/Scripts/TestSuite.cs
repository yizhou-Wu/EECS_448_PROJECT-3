using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TestSuite : MonoBehaviour {

    // Use this for initialization
    public Rigidbody2D user;

    void Start () {
        DontDestroyOnLoad(this);
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
        if(GameManager.testmode==true)
        {
            Debug.Log("test");
            Invoke("MoveRightTest", 1);
            Invoke("MoveLeftTest", 3);
            Invoke("MoveRightTest", 5);
        }

    }
    void MoveLeftTest () 
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
