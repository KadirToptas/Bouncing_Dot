using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Controller : MonoBehaviour
{
    private GameManager gm;
    
    public Rigidbody2D rb;

    public SpriteRenderer sr;

    public Sprite[] ballSprites;

    public float jumpForce;

    public string currentColor;
    void Start()
    {
        gm = GameObject.FindObjectOfType<GameManager>();
        RandomBallColor(3);
        
    }

    void Update()
    {
        
    }

    public void RandomBallColor(int index)
    {
        switch (index)
        {
            case 0: currentColor = "Red";
                sr.sprite = ballSprites[0];
                gameObject.tag = "Red";
                break;
            
            case 1: currentColor = "Yellow";
                sr.sprite = ballSprites[1]; 
                gameObject.tag = "Yellow"; 
                break;
            
            case 2: currentColor = "Purple";
                sr.sprite = ballSprites[2]; 
                gameObject.tag = "Purple"; 
                break;
            
            case 3: currentColor = "Green";
                sr.sprite = ballSprites[3]; 
                gameObject.tag = "Green"; 
                break;
            
            case 4: currentColor  = "Blue";
                sr.sprite = ballSprites[4]; 
                gameObject.tag = "Blue"; 
                break;
            
            case 5: currentColor = "Orange";
                sr.sprite = ballSprites[5];
                gameObject.tag = "Orange"; 
                break;
        }
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        rb.velocity = Vector3.up * jumpForce;
        if (other.gameObject.tag != currentColor)
        {
            gm.RestartGame();
        }
        else
        {
            gm.score += 1;
            int _randomNumber = UnityEngine.Random.Range(0,6);
            RandomBallColor(_randomNumber);

        }
    }
}
