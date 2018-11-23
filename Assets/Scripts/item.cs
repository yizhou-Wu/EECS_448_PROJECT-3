using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class item : MonoBehaviour {


    public int LevelToLoad;
    public Text m_money;


    public float money;
    public static float totalmoney = 50.00f;

	// Use this for initialization
	void Start () {
       display();
	}
	

    public void item1()
    {

        if (money - 10 == 0)
        {
           // Application.LoadLevel(7);
            money = 0;
            display();
        }
        else if(money-10 <0)
        {
            //Application.LoadLevel(7);
            UnityEditor.EditorUtility.DisplayDialog("Error", "you dont have enough money", "Alright");
        }
        else
        {
            money -= 10;
            display();
        }

    }

    public void item2()
    {

        if (money - 5 == 0)
        {
            money = 0;
            display();
            //Application.LoadLevel(7);
        }
        else if (money - 5 < 0)
        {
            UnityEditor.EditorUtility.DisplayDialog("Error", "you dont have enough money", "Alright");
        }
        else
        {
            money -= 5;
            display();
        }
    }

    public void item3()
    {

        if (money - 1 == 0)
        {
            money = 0;
            display();
            // Application.LoadLevel(7);
        }
        else if (money - 1 < 0)
        {
            UnityEditor.EditorUtility.DisplayDialog("Error", "you dont have enough money", "Alright");
        }
        else
        {
            money -= 1;
            display();
        }
    }

    public void item4()
    {

        if (money - 3 == 0)
        {
            money = 0;
            display();
            //Application.LoadLevel(7);
        }
        else if (money - 3 < 0)
        {
            UnityEditor.EditorUtility.DisplayDialog("Error", "you dont have enough money", "Alright");
        }
        else
        {
            money -= 3;
            display();
        }
    }

    public void item5()
    {

        if (money - 7 == 0)
        {
            money = 0;
            display();
            // Application.LoadLevel(7);
        }
        else if (money - 7 < 0)
        {
            UnityEditor.EditorUtility.DisplayDialog("Error", "you dont have enough money", "Alright");
        }
        else
        {
            money -= 7;
            display();
        }
    }

    public void item6()
    {

        if (money - 13 == 0)
        {
            money = 0;
            display();
            //Application.LoadLevel(7);
        }
        else if (money - 13 < 0)
        {
            UnityEditor.EditorUtility.DisplayDialog("Error", "you dont have enough money", "Alright");
        }
        else
        {
            money -= 13;
            display();
        }
    }

    public void item7()
    {

        if (money - 15 == 0)
        {
            money = 0;
            display();
            //Application.LoadLevel(7);
        }
        else if (money - 15 < 0)
        {
            UnityEditor.EditorUtility.DisplayDialog("Error", "you dont have enough money", "Alright");
        }
        else
        {
            money -= 15;
            display();
            UnityEditor.EditorUtility.DisplayDialog("one of the answer for midterm", "An exceptio in C++ can be generated using throw.", "Okay");            
        }
    }

    public void item8()
    {

        if (money - 15 == 0)
        {
            money = 0;
            display();
            //Application.LoadLevel(7);
        }
        else if (money - 15 < 0)
        {
            UnityEditor.EditorUtility.DisplayDialog("Error", "you dont have enough money", "Alright");
        }
        else
        {
            money -= 15;
            display();
            UnityEditor.EditorUtility.DisplayDialog("one of the answer for midterm", "A C++ code line ends with ';'", "Okay");
        }
    }

    public void item9()
    {

        if (money - 30 == 0)
        {
            money = 0;
            display();
            //Application.LoadLevel(7);
        }
        else if (money - 30 < 0)
        {
            UnityEditor.EditorUtility.DisplayDialog("Error", "you dont have enough money", "Alright");
        }
        else
        {
            money -= 30;
            display();
            UnityEditor.EditorUtility.DisplayDialog("Answer for midterm", "BCDBC", "Okay");
        }
    }



  public void display()
  {
     m_money.text = money.ToString();
  }

    public  void total()
    {
        totalmoney = money;
    }
	// Update is called once per frame
	void Update () {
        total();
	}
}
