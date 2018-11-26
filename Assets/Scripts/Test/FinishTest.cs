/** 
 * @author Team FourFour8
 * @file FinishTest.cs
 * @date Nov 2018
 * @brief FinishTest class. This class takes charge of the properties of the FinishTest.
**/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FinishTest : MonoBehaviour
{
    public Button playagain;
    // Use this for initialization
    /**
    * @pre None.
    * @post Run the function automaticlly.
    * @para None.   
    **/
    void Awake()
    {
        if (GameManager.testmode == true)
        {
            Invoke("playagaintest", 1);
        }
    }
    /**
    * @pre None.
    * @post Simullate the button press.
    * @para None.   
    **/
    void playagaintest()
    {
        GameManager.testmode = false;
        playagain.onClick.Invoke();
        Debug.Log("Finish Test");
    }
}

