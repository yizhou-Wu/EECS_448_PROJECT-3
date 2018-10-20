using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GOBACK : MonoBehaviour {

    // Use this for initialization
    public Button bt;
    void Start()
    {
        bt.onClick.AddListener(TaskOnClick);
    }
    void TaskOnClick()
    {
        print("Button Click");
        SceneManager.LoadScene("base");
    }
}
