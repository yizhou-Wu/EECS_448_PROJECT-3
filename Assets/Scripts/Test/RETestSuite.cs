using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RETestSuite : MonoBehaviour {
    public Button roll;
    public Button okay;
    public RandomEvent m_event;
    // Use this for initialization
    void Awake () {
        if(GameManager.testmode==true)
        {
            Debug.Log("TRRIGER EVENT:" + m_event.eventname);
            Invoke("clickroll", 0);
            Invoke("clickokay", 2);
        }
    }
	void clickroll()
    {
        roll.onClick.Invoke();
        Debug.Log("ROLL FUNCTION PASS");
        Debug.Log("ROLLED :" + DialogueManager.DiceNum);
    }
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
