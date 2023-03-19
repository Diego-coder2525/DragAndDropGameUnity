using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameMaster : MonoBehaviour
{

    public GameObject restartPanel;
    public GameObject winPanel;
    public TextMeshProUGUI score;
    public GameObject gameController;
    public bool GO;

    GameObject worm1, worm2, worm3;
    float timer;


    private void Start()
    {
        worm1 = GameObject.Find("Worm");
        worm2 = GameObject.Find("Worm1");
        worm3 = GameObject.Find("Worm2");

        worm1.SetActive(false);
        worm2.SetActive(false);
        worm3.SetActive(false);
        timer = 0;
    }
    public void GameOver()
    {
        GO = true;
        restartPanel.SetActive(true);
    }
    private void Update()
    {
        if (GO == false)
        {
            timer += Time.deltaTime;
            int seconds = (int)timer % 60;
            score.text =seconds+"";

            switch (seconds)
            {
                case 10:
                    worm1.SetActive(true);
                break;
                case 20:
                    worm2.SetActive(true);
                    break;
                case 40:
                    worm3.SetActive(true);
                    break;
                case 59:
                    GO = true;
                    winPanel.SetActive(true);
                    break;
            }
        }


    }
    public void goToGameScene()
    {

        gameController.GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("Game");
        
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void goToMainMenu()
    {
        SceneManager.LoadScene("Start");
    }
    
}
