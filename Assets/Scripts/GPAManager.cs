using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GPAManager : MonoBehaviour {
    public static float m_maxGPA;
    public static int m_money;
    public static float m_currentGPA;
	// Use this for initialization
	void Start () {
        m_currentGPA = m_maxGPA;
	}
	
	// Update is called once per frame
	void Update () {
        if(m_currentGPA<0)
        {
            gameObject.SetActive(false);
        }
	}
    public void Hurtplayer()
    {

    }
}
