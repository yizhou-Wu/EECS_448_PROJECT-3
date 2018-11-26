/** 
 * @author Team FourFour8
 * @file ShopTest.cs
 * @date Nov 2018
 * @brief MidtermTest class. This class takes charge of the properties of the ShopTest.
**/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShopTest : MonoBehaviour {

    // Use this for initialization
    public Button hamburger;
    public Button coffee;
    public Button chocolate;
    public Button book1;
    public Button book2;
    public Button book3;
    public Button back;
    /**
    * @pre None.
    * @post Run the functions
    * @para None.   
    **/
    void Start ()
    {
		if(GameManager.testmode==true)
        {
            TestClick();
            PlayerManager.AllowUse = true;
        }
	}
    /**
    * @pre None.
    * @post Click the buttons in the shop to test if the money of the user changed.
    * @para None.   
    **/
    void TestClick()
    {
        float initial = PlayerManager.Money;
        Debug.Log("BEFORE ENTERING THE SHOP, REMAIN MONEY:" + PlayerManager.Money);
        hamburger.onClick.Invoke();
        Debug.Log("HAMBURGER COSTS 10$, REMAIN MONEY:" + PlayerManager.Money);
        coffee.onClick.Invoke();
        Debug.Log("COFFEE COSTS 5$, REMAIN MONEY:" + PlayerManager.Money);
        chocolate.onClick.Invoke();
        Debug.Log("CHOCOLATE COSTS 1$, REMAIN MONEY:" + PlayerManager.Money);
        book1.onClick.Invoke();
        Debug.Log("BOOK1 COSTS 15$, REMAIN MONEY:" + PlayerManager.Money);
        book2.onClick.Invoke();
        Debug.Log("BOOK2 COSTS 15$, REMAIN MONEY:" + PlayerManager.Money);
        book3.onClick.Invoke();
        Debug.Log("BOOK3 COSTS 30$, REMAIN MONEY:" + PlayerManager.Money);
        if(PlayerManager.Money==(initial-10-1-5-15-15-30))
        {
            Debug.Log("ShopTest PASSED");
        }
        back.onClick.Invoke();
    }
}
