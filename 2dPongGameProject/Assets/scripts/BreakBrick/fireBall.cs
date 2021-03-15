using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class fireBall : MonoBehaviour
{
    public Transform firePoint;
    public GameObject ballPrefab;
    Rigidbody2D rb;
    public Player1 player1;
    public GameObject ball;
    public Text balltext;
    

    public float ballpower = 20f;

     void Start()
    {
        player1 = FindObjectOfType<Player1>();

    }
    void Update()
    {
    
        if(player1.PlayersCurrentBallNumber == 0)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                player1.isShooting = true;
                SpawnBall();
            }
            
            if (Input.GetKeyUp(KeyCode.Mouse0))
            {
               player1.isShooting = false;
               PushBall();
               player1.PlayersCurrentBallNumber = 1;
               // ball spawnlanıyo ve haklardan biri kullanılıyor
               balltext.text = (player1.PlayerBallChance - 1).ToString();
                
            }
            
        }
        
    }

    private void PushBall()
    {
        Rigidbody2D rb = ball.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * ballpower, ForceMode2D.Impulse);
    }

    void SpawnBall()
    {
        ball = Instantiate(ballPrefab, firePoint.position, firePoint.rotation);
        
    }
    
}
