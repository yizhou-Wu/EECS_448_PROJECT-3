using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FinishTest : MonoBehaviour
{
    public Button playagain;
    // Use this for initialization
    void Awake()
    {
        if (GameManager.testmode == true)
        {
            Invoke("playagaintest", 1);
        }
    }
    void playagaintest()
    {
        playagain.onClick.Invoke();
        Debug.Log("Finish Test");
    }
}

