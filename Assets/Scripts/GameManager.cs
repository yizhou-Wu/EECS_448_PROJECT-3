using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    bool GameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject EndGameUI;
    public void EndGame()
    {
        if (GameHasEnded == false)
        {
            GameHasEnded = true;
            Debug.Log("game over!");
            EndGameUI.SetActive(true);
        }
    }
    public void Restart()
    {
        foreach (GameObject o in Object.FindObjectsOfType<GameObject>())
        {
            Destroy(o);
        }
        SceneManager.LoadScene("base");
        //Destroy(all);
    }
    public void ExitGame()
    {
        Application.Quit();
    }

}
