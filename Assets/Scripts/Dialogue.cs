/** 
 * @author Team FourFour8
 * @file DialogueManager.cs
 * @date Nov 2018
 * @brief DialogueManager class. This class takes charge of the properties of the DialogueManager.
**/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Dialogue {
    public string eventname;
    [TextArea(3,10)]
    public string[] sentences;
}
