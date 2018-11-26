/** 
 * @author Team FourFour8
 * @file Stage4.cs
 * @date October 2018
 * @brief Stage4 class. This class takes charge of the properties of the Stage4.
**/
using UnityEngine;
//using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Collections;
using UnityEditor;

public class SwitchSceneButton2 : MonoBehaviour
{
    //[HideInInspector]
    public int LevelToLoad;
    public GameObject ErrorPanel;
    /**
    * @pre  None
    * @post set up button 
    * @para None.
    **/
    void Awake()
    {
        var btn = GetComponent<Button>();
        if (btn != null)
        {
            btn.onClick.AddListener(OnMouseDown);
           
        }
        
    }

    /**
    * @pre  None
    * @post go to the base scene after clicking the button
    * @para None.
    **/
    void OnMouseDown()
    {
        PlayerManager.userName = GetUserName.userName;

        if (PlayerManager.userName == "")
        {
            ErrorPanel.SetActive(true);
            //UnityEditor.EditorUtility.DisplayDialog("HMMMMMM", "A name for your character is needed to enter the game. :)", "Okay");
        }
        else
        {
           
            Application.LoadLevel(LevelToLoad);
        }
    }



     

}