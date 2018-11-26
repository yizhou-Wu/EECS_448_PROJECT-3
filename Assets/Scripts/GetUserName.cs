using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetUserName : MonoBehaviour
{


    //public GameObject text;
    //public GameObject inputtext;
    public static string userName;

    public void Start()
    {
        //text.GetComponent<Text>().text = "Text";
        //inputtext.GetComponent<InputField>().text = "InputText";
        
    }

    void username()
    {
        userName = GameObject.Find("userName").GetComponent<InputField>().text;        
    }

     public void Update()
    {
        username();   
    }



}
