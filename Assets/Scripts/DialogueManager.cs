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
    

}
