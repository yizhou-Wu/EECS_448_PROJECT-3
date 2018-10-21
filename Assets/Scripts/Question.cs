using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Question : MonoBehaviour
{

    public Text totalpoint;

    public static int point;
    public static int point1;
    public static int point2;
    public static int point3;
    public static int point4;
    public static int totalpoint1;

    public static float GPA;

    List<string> questions = new List<string>() { "A is member of object B", "B is member of Object A", "Product of A and B", "None of these" };
    List<string> questions1 = new List<string>() { "Operator-&", "Operator-||", "Operator-&&", "Operator +" };
    List<string> questions2 = new List<string>() { "A Slash (/)", "A Fullstop(.)", "A Comma (,)", "A Semicolon (;)" };
    List<string> questions3 = new List<string>() { "<fiostream>", "<ifstream>", "<ofstream>", "<fstream>" };
    List<string> questions4 = new List<string>() { "thrown", "threw", "throw", "throws" };
    public Dropdown dropdown;
    public Dropdown dropdown1;
    public Dropdown dropdown2;
    public Dropdown dropdown3;
    public Dropdown dropdown4;
    // Use this for initialization
    void Start()
    {
        questionlist();
        questionlist1();
        questionlist2();
        questionlist3();
        questionlist4();
    }

    void questionlist()
    {

        dropdown.AddOptions(questions);

    }

    void questionlist2()
    {

        dropdown2.AddOptions(questions2);

    }

    void questionlist3()
    {

        dropdown3.AddOptions(questions3);

    }

    void questionlist4()
    {

        dropdown4.AddOptions(questions4); ;

    }


    void questionlist1()
    {
        dropdown1.AddOptions(questions1);
    }



    public void DropdownIndex(int index)
    {
        if (index == 1)
        {
            point = 20;
            GPA = totalpoint1 / 100f;
        }
        else
        {
            point = 0;
        }
    }

    public void DropdownIndex1(int index)
    {
        if (index == 2)
        {
            point1 = 20;
            GPA = totalpoint1 / 100f;
        }
        else
        {
            point1 = 0;
        }
    }

    public void DropdownIndex2(int index)
    {
        if (index == 3)
        {
            point2 = 20;
            GPA = totalpoint1 / 100f;
        }
        else
        {
            point2 = 0;
        }
    }

    public void DropdownIndex3(int index)
    {
        if (index == 3)
        {
            point3 = 20;
            GPA = totalpoint1 / 100f;
        }
        else
        {
            point3 = 0;
        }
    }

    public void DropdownIndex4(int index)
    {
        if (index == 2)
        {
            point4 = 20;
            GPA = totalpoint1 / 100f;
        }
        else
        {
            point4 = 0;
        }
    }

    public void total()

    {
        totalpoint1 = point + point1 + point2 + point3 + point4;
        Playermove.GPA = totalpoint1 / 100;
        totalpoint.text = totalpoint1.ToString();

    }

    public void Update()
    {
        total();
    }
}