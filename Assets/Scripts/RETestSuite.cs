using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RETestSuite : MonoBehaviour {
    public Button roll;
    public Button okay;
    // Use this for initialization
    void Awake () {
        if(GameManager.testmode==true)
        {
            Invoke("clickroll", 1);
            Debug.Log("ROLL FUNCTION PASS");
            Debug.Log("ROLLED :" + DialogueManager.DiceNum);
            Invoke("clickokay", 2);
            Debug.Log("RANDOM EVENT GO BACK PASS");
        }
    }
	void clickroll()
    {
        roll.onClick.Invoke();
    }
    void clickokay()
    {
        okay.onClick.Invoke();
    }
    // Update is called once per frame
    void Update()
    {

    }
}
