using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TicTest : MonoBehaviour {
    public Button Test;
    public Button Back;
    public bool tested=false;
    // Use this for initialization
    
    void Start () {
        if(tested==false)
        {
            if (GameManager.testmode == true)
            {
                Test.onClick.Invoke();
                tested = true;
            }
        }
        else
        {
            if(GameManager.testmode == true)
            {
                Back.onClick.Invoke();
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
