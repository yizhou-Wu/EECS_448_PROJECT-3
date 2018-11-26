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
    void Start ()
    {
		if(GameManager.testmode==true)
        {
            TestClick();
            PlayerManager.AllowUse = true;
        }
	}
	
	// Update is called once per frame
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
        book1.onClick.Invoke();
    }
}
