using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartManager : MonoBehaviour
{
 

    public void goToGameScene()
    {

        GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("Game");

    }
    public void exitGame()
    {
        Application.Quit();
    }
}
