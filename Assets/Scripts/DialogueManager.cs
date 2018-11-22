using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueManager : MonoBehaviour {
    public RandomEvent m_event;
    public Text eventName;
    public Text text;
    private Queue<string> sentences;
    public int DiceNum;
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
    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {

            EndDialogue();
            SceneManager.LoadScene("base");
        }
        string sentence = sentences.Dequeue();
        text.text = sentence;
    }
    public void EndDialogue()
    {
           Debug.Log("end of it");
    }
    public void RollDice()
    {
        DiceNum = Random.Range(1,6);
        Debug.Log(DiceNum);
    }
    public void ResultGenerate()
    {
        RollDice();
        if(DiceNum==1||DiceNum==2||DiceNum==3)
        {

            UnityEditor.EditorUtility.DisplayDialog("Worst Case!", "Sadly,The gril turned down your invitation.Nothing happened", "Okay");
            SceneManager.LoadScene("base");
        }
        else
        {
            Debug.Log(PlayerManager.Money);
            PlayerManager.Money -= 50;
            Debug.Log(PlayerManager.Money);
            UnityEditor.EditorUtility.DisplayDialog("Best Case!", "She accepted your invitation and you had a nice meal. You cost 50$.", "Okay");
            SceneManager.LoadScene("base");
        }
    }

}
