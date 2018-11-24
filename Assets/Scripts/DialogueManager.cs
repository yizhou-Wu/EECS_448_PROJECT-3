using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueManager : MonoBehaviour {
    public RandomEvent m_event;
    public Text eventName;
    public Text eventText;
    public Text Result;
    public Text ResultText;
    public GameObject Basepanel;
    public GameObject Resultpanel;
    private Queue<string> sentences;
    private int DiceNum;
    public void Start()
    {
        sentences = new Queue<string>();
        eventName.text = m_event.eventname;
        sentences.Clear();
        foreach (string sentence in m_event.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }
    void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {

            EndDialogue();
            SceneManager.LoadScene("base");
        }
        string sentence = sentences.Dequeue();
        eventText.text = sentence;
    }
    void EndDialogue()
    {
           Debug.Log("end of it");
    }
    void RollDice()
    {
        DiceNum = Random.Range(1,6);
    }
    public void Goback()
    {
        SceneManager.LoadScene("base");
    }
    public void ResultGenerate_1()//Dating
    {

        RollDice();
        Basepanel.SetActive(false);
        Resultpanel.SetActive(true);
        if(DiceNum==1||DiceNum==2||DiceNum==3)
        {
            Result.text = "Worst Case!";
            ResultText.text = "Sadly,The gril turned down your invitation.Nothing happened.";
        }
        else
        {
            PlayerManager.Money -= 50;
            Result.text = "Best Case!";
            ResultText.text = "She accepted your invitation and you had a nice meal. You cost 50$";
        }
    }
    public void ResultGenerate_2()//Work
    {
        RollDice();
        Basepanel.SetActive(false);
        Resultpanel.SetActive(true);
        if (DiceNum == 1 || DiceNum == 2 || DiceNum == 3)
        {
            PlayerManager.Money += 5;
            Result.text = "Worst Case!";
            ResultText.text = "Work was as you expected it to be: bad.No tips were handed out.You earned $5";
        }
        else
        {
            PlayerManager.Money += 15;
            Result.text = "Best Case!";
            ResultText.text = "Work went well. You are not very tired and got some good tips.  You have earned $15";
        }
    }
    public void ResultGenerate_3()//Rain
    {
        RollDice();
        Basepanel.SetActive(false);
        Resultpanel.SetActive(true);
        if (DiceNum == 1 || DiceNum == 2 || DiceNum == 3)
        {
            PlayerManager.GPA -= 0.1f;
            PlayerManager.Money -= 10;
            Result.text = "Worst Case!";
            ResultText.text = "Oh no!Water has seeped into your bag and as a result, your homework is ruined and your laptop is broken, lowering your GPA.";
        }
        else
        {
            Result.text = "Best Case!";
            ResultText.text = "You are a little wet, but your homework and laptop are safe.  Get to class.";
        }
    }
    public void ResultGenerate_4()//sick
    {
        RollDice(); 
        Basepanel.SetActive(false);
        Resultpanel.SetActive(true);
        if (DiceNum == 1 || DiceNum == 2 || DiceNum == 3)
        {
            PlayerManager.GPA -= 0.1f;
            PlayerManager.Health -= 10;
            Result.text = "Worst Case!";
            ResultText.text = "You try to get out of bed but you can’t.Even sending emails is too hard.  Ouch, that hurts...your GPA that is.";
        }
        else
        {
            PlayerManager.Health -= 5;
            Result.text = "Worst Case!";
            ResultText.text = "You fight and fight and manage to get all of your work done.You are tired, but it all worked out.";
        }
    }

}
