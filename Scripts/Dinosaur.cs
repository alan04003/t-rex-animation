using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dinosaur : MonoBehaviour
{
    public GameObject stand;
    public GameObject crouch;
    Rigidbody2D rb;

    bool isJumping;
    public GameManager gameManager; 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isJumping = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space") && isJumping == false) //om jag trycker space och om han inte redan hoppar 
        {
            rb.velocity = new Vector3(0, 20, 0); //sätter hanstigheten på hoppet 
            isJumping = true; 
        }

        if (Input.GetKey("down") && isJumping == false)//om pill neråt trykcs så byts aktiv sprite  
        {
            crouch.SetActive(true);
            stand.SetActive(false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)//efter du hoppar så återställler denna till att den inte hoppar 
    {
        isJumping = false; 
    }

    private void OnTriggerEnter2D(Collider2D collision) //om du collidar med ett hinder blir det game over
    {
        if (collision.tag == "Hinder")
        {
            gameManager.GameOver(); 
        }
    }

}

