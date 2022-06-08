using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hinder : MonoBehaviour
{
    float maxTime;
    float timer;

    public GameObject hinder1; 
    public GameObject hinder2; 
    public GameObject hinder3; 
    public GameObject hinder4; 

    int choosehinder;
    // Start is called before the first frame update
    void Start()
    {
        maxTime = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime; //sätter timer 
        if(timer >= maxTime)//om timer är lika med eller större som maxtimne genererar den ett hinder 
        {
            GenerateHinder();
            timer = 0; //skapar hinder
        }
    }

    void GenerateHinder()
    {
        choosehinder = Random.Range(1, 5); 
        if (choosehinder == 1) { GameObject newGameObject = Instantiate(hinder1); }
        if (choosehinder == 2) { GameObject newGameObject = Instantiate(hinder2); }
        if (choosehinder == 3) { GameObject newGameObject = Instantiate(hinder3); }
        if (choosehinder == 4) { GameObject newGameObject = Instantiate(hinder4); }

    }
}
