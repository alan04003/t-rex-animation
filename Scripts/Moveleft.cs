using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveleft : MonoBehaviour
{
    public float speed;
    public float start;
    public float end;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y); //allt som har denna på sig rör sig nehativt i x axeln och flyttas inte i y axeln
        if(transform.position.x <= end)
        {
            if(gameObject.tag == "Hinder")
            {
                Destroy(gameObject);// om det är ett hinder förstörs det när de kommer till end 
            }
            else
            {
                transform.position = new Vector2(start, transform.position.y); //flyttar de objekt som kommer till end till start 
            }

        }
        
    }
}
