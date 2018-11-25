using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExamTest : MonoBehaviour {

    // Use this for initialization
    public Button okay;
    void Start () {
        if (GameManager.testmode == true)
        {
            int q1 = Random.Range(0, 3);
            int q2 = Random.Range(0, 3);
            int q3 = Random.Range(0, 3);
            int q4 = Random.Range(0, 3);
            int q5 = Random.Range(0, 3);
            Debug.Log("CHOICES:" + q1 + "," + q2 + "," + q3 + "," + q4+","+q5);
            Question.DropdownIndex(q1);
            Question.DropdownIndex1(q2);
            Question.DropdownIndex2(q3);
            Question.DropdownIndex3(q4);
            Question.DropdownIndex4(q5);
            Debug.Log("POINTS GET:"+Question.totalpoint1+ "(CORRECT ANSWER:1,2,3,3,2)");
            okay.onClick.Invoke();
        }
    }
}
