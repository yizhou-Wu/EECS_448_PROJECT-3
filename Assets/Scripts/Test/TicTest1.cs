/** 
 * @author Team FourFour8
 * @file DialogueManager.cs
 * @date Nov 2018
 * @brief DialogueManager class. This class takes charge of the properties of the DialogueManager.
**/
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;




public class TicTest1 : MonoBehaviour
{
    public Button Back;
    //public bool tested = false;
    // Use this for initialization

    void Start()
    {
            if (GameManager.testmode == true)
            {
                Back.onClick.Invoke();

            Debug.Log("Test success");

            }

        
    }

    // Update is called once per frame
    void Update()
    {

    }
}