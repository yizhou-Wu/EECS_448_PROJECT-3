using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GOBACK : MonoBehaviour {
    public Button bt;
    /**
    * @pre None.
    * @post Load the scene depending on the collision tag.
    * @para The objects that collide.
    **/
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
