using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {
    public Slider GPABar;
    public Text GPAText;
    //public GPAManager GPA;
    public float gpatext;
	// Use this for initialization
	void Start () {
        GPABar.value = Playermove.GPA;
        Debug.Log(GPABar.value);
    }
	
	// Update is called once per frame
	void Update () {
        GPABar.maxValue = 1;
        GPABar.value = Playermove.GPA;
        //GPAText = Playermove.GPA.ToString();
	}
}
