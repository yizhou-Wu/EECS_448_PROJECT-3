using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class item : MonoBehaviour {

    public GameObject book1;
    public GameObject book2;
    public GameObject book3;
    public GameObject enoughmoney;
    public int LevelToLoad;
    public Text m_money;
    public bool buy1 = true;
    public bool buy2 = true;
    public bool buy3 = true;


    public float money;
    public static float totalmoney;

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
            enoughmoney.SetActive(true);
            //Application.LoadLevel(7);
            //UnityEditor.EditorUtility.DisplayDialog("Error", "you dont have enough money", "Alright");
        }
        else
        {
            PlayerManager.Health += 10;
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
            enoughmoney.SetActive(true);
            //UnityEditor.EditorUtility.DisplayDialog("Error", "you dont have enough money", "Alright");
        }
        else
        {
            PlayerManager.Health += 5;
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
            enoughmoney.SetActive(true);
            //UnityEditor.EditorUtility.DisplayDialog("Error", "you dont have enough money", "Alright");
        }
        else
        {
            PlayerManager.Health += 1;
            money -= 1;
            display();
        }
    }







    public void item7()
    {
        if (buy1 == true)
      {
            if (money - 15 == 0)
            {
                money = 0;
                display();
                book1.SetActive(true);

                //Application.LoadLevel(7);
            }
            else if (money - 15 < 0)
            {
                enoughmoney.SetActive(true);
                //book1.SetActive(false);
                //UnityEditor.EditorUtility.DisplayDialog("Error", "you dont have enough money", "Alright");
            }
            else
            {
                money -= 15;
                display();
                book1.SetActive(true);
                buy1 = false;
                //UnityEditor.EditorUtility.DisplayDialog("one of the answer for midterm", "An exceptio in C++ can be generated using throw.", "Okay");            
            }
        }
    }

    public void item8()
    {
        if (buy2 == true)
        {
            if (money - 15 == 0)
            {
                money = 0;
                display();
                book2.SetActive(true);
                //Application.LoadLevel(7);
            }
            else if (money - 15 < 0)
            {
                enoughmoney.SetActive(true);
                //UnityEditor.EditorUtility.DisplayDialog("Error", "you dont have enough money", "Alright");
            }
            else
            {
                money -= 15;
                display();
                book2.SetActive(true);
                buy2 = false;
                //UnityEditor.EditorUtility.DisplayDialog("one of the answer for midterm", "A C++ code line ends with ';'", "Okay");
            }
        }
    }

    public void item9()
    {
        if (buy3 == true)
        {
            if (money - 30 == 0)
            {
                money = 0;
                display();
                book3.SetActive(true);
                //Application.LoadLevel(7);
            }
            else if (money - 30 < 0)
            {
                enoughmoney.SetActive(true);
                //UnityEditor.EditorUtility.DisplayDialog("Error", "you dont have enough money", "Alright");
            }
            else
            {
                money -= 30;
                display();
                book3.SetActive(true);
                buy3 = false;
                //UnityEditor.EditorUtility.DisplayDialog("Answer for midterm", "BCDBC", "Okay");
            }
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
