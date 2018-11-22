using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class RandomEvent : MonoBehaviour
{
    public string eventname;
    [TextArea(3, 10)]
    public string[] sentences;
}
