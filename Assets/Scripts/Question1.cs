using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEditor;

public class Question1 : MonoBehaviour
{
    //create a new text for totalpoint
    public Text totalpoint;
    //point for each question
    public static int point;
    public static int point1;
    public static int point2;
    public static int point3;
    public static int point4;
    public static int totalpoint1;
    public  static float GPA1;


    //element in each dropdown
    List<string> questions = new List<string>() { "void display()", "void display() const", "const void display()", "void const display()" };
    List<string> questions1 = new List<string>() { "Copy constructor", "Assignment", "Constructor", "All the above" };
    List<string> questions2 = new List<string>() { "Friend function", "Inline function", "Static function", "constant function" };
    List<string> questions3 = new List<string>() { "int foo(int x=5, int y, int z=10)", "int foo(int x=5, int y =10, int z)", "int foo(int x, int y =5, int z=10)", "all are correct" };
    List<string> questions4 = new List<string>() { "virtual void foo() {} = 0", "void virtual foo()= { 0 }", "virtual void foo() =0", "None" };
    public Dropdown dropdown;
    public Dropdown dropdown1;
    public Dropdown dropdown2;
    public Dropdown dropdown3;
    public Dropdown dropdown4;
    // Use this for initialization
    /**
     * @pre valid questionlist
     * @post set the vaild questionlist for each question
     * @para None.
     **/
    void Start()
    {
        questionlist();
        questionlist1();
        questionlist2();
        questionlist3();
        questionlist4();
    }

    /**
     * @pre valid questionlist
     * @post add elements into the first dropdown 
     * @para None.
     **/
    void questionlist()
    {

        dropdown.AddOptions(questions);

    }

    /**
    * @pre valid questionlist
    * @post add elements into the third dropdown 
    * @para None.
    **/
    void questionlist2()
    {

        dropdown2.AddOptions(questions2);
    }

    /**
    * @pre valid questionlist
    * @post add elements into the fourth dropdown 
    * @para None.
    **/
    void questionlist3()
    {
        dropdown3.AddOptions(questions3);
    }

    /**
    * @pre valid questionlist
    * @post add elements into the fifth dropdown 
    * @para None.
    **/
    void questionlist4()
    {
        dropdown4.AddOptions(questions4); ;
    }

    /**
    * @pre valid questionlist
    * @post add elements into the second dropdown 
    * @para None.
    **/
    void questionlist1()
    {
        dropdown1.AddOptions(questions1);
    }


    /**
    * @pre valid dropdown
    * @post add elements into the first dropdown 
    * @para index of anwser(int).
    **/
    public static void DropdownIndex(int index)
    {
        if (index == 1)
        {
            totalpoint1 += 10;

        }
        else
        {
            point = 0;
        }
    }


    /**
    * @pre valid dropdown
    * @post add elements into the second dropdown 
    * @para index of anwser(int).
    **/
    public static void DropdownIndex1(int index)
    {
        if (index == 3)
        {
            totalpoint1 += 10;

        }
        else
        {
            point1 = 0;
        }
    }


    /**
    * @pre valid dropdown
    * @post add elements into the third dropdown 
    * @para index of anwser(int).
    **/
    public static void DropdownIndex2(int index)
    {
        if (index == 2)
        {
            totalpoint1 += 10;

        }
        else
        {
            point2 = 0;
        }
    }

    /**
    * @pre valid dropdown
    * @post add elements into the fourth dropdown 
    * @para index of anwser(int).
    **/
    public static void DropdownIndex3(int index)
    {
        if (index == 2)
        {
            totalpoint1 += 10;

        }
        else
        {
            point3 = 0;
        }
    }


    /**
    * @pre valid dropdown
    * @post add elements into the fifth dropdown 
    * @para index of anwser(int).
    **/
    public static void DropdownIndex4(int index)
    {
        if (index == 2)
        {
            totalpoint1 += 10;

        }
        else
        {
            point4 = 0;
        }
    }


    /**
    * @pre valid point
    * @post count the totalpoint 
    * @para None.
    **/
    public void Total()

    {
        totalpoint1 = point + point1 + point2 + point3 + point4;     
        GPA1 = totalpoint1 / 100f;
    }
    /**
     * @pre  None
     * @post update the total point
     * @para None.
     **/
    public void Update()
    {
        Total();
    }
}