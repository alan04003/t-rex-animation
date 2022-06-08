using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject GameOverPanel; 
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1; //rör sig vanlig hastighet 
    }

    public void GameOver()//
    {
        Time.timeScale = 0; //när gameover spelet stannar 
        GameOverPanel.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Game"); //startar om 
    }
}