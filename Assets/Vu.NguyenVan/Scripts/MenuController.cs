using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

    public void NewGame(GameObject game)
    {
        SceneManager.LoadScene(1);
    }

    public void Options()
    {
        Debug.Log("Options");
    }


    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
