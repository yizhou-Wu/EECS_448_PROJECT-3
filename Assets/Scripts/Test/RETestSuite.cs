/** 
 * @author Team FourFour8
 * @file RETestSuite.cs
 * @date Nov 2018
 * @brief RETestSuite class. This class takes charge of the properties of the RETestSuite.
**/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RETestSuite : MonoBehaviour {
    public Button roll;
    public Button okay;
    public RandomEvent m_event;
    // Use this for initialization
    /**
   * @pre None.
   * @post Once get inside the random event, click the button automaticlly.
   * @para None.   
   **/
    void Awake () {
        if(GameManager.testmode==true)
        {
            Debug.Log("TRRIGER EVENT:" + m_event.eventname);
            Invoke("clickroll", 0);
            Invoke("clickokay", 2);
        }
    }
    /**
    * @pre None.
    * @post Once get inside the random event, click the ROLL button automaticlly.
    * @para None.   
    **/
    void clickroll()
    {
        roll.onClick.Invoke();
        Debug.Log("ROLL FUNCTION PASS");
        Debug.Log("ROLLED :" + DialogueManager.DiceNum);
    }
    /**
    * @pre None.
    * @post Once get inside the random event, click the goback automaticlly.
    * @para None.   
    **/
    void clickokay()
    {
        okay.onClick.Invoke();
        
        Debug.Log("RANDOM EVENT GO BACK PASS");
    }
    // Update is called once per frame
    void Update()
    {

    }
}
