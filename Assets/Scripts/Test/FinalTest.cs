/** 
 * @author Team FourFour8
 * @file FinalTest.cs
 * @date Nov 2018
 * @brief FinalTest class. This class takes charge of the properties of the Finaltest.
**/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalTest : MonoBehaviour
{
    public Button okay;
    /**
    * @pre None.
    * @post Generate random answers to test the result function.
    * @para None.   
    **/
    void Start()
    {
        if (GameManager.testmode == true)
        {
            int q1 = Random.Range(0, 3);
            int q2 = Random.Range(0, 3);
            int q3 = Random.Range(0, 3);
            int q4 = Random.Range(0, 3);
            int q5 = Random.Range(0, 3);
            Debug.Log("CHOICES:" + q1 + "," + q2 + "," + q3 + "," + q4 + "," + q5);
            Question1.DropdownIndex_T(q1);
            Question1.DropdownIndex1_T(q2);
            Question1.DropdownIndex2_T(q3);
            Question1.DropdownIndex3_T(q4);
            Question1.DropdownIndex4_T(q5);
            Debug.Log("POINTS GET:" + Question.totalpoint2 + "(CORRECT ANSWER:1,3,3,2,2)");
            okay.onClick.Invoke();
        }
    }
}
