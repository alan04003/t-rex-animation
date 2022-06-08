using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Score : MonoBehaviour
{
    public int score; 
    public UnityEngine.UI.Text scoreText;

    float timer;
    float maxTime; 
    // Start is called before the first frame update
    void Start()
    {
        score = 0; 
        scoreText = gameObject.GetComponent<UnityEngine.UI.Text>();
        scoreText.text = "00000";
        maxTime = 0.1f; 
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= maxTime)
        {
            score++;
            scoreText.text = score.ToString("00000");
            timer = 0; 
        }
    }
}
