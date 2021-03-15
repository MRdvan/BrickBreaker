using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    public int PlayerBallChance;
    public int PlayerGold;
    public float PlayerSize;
    

    public float moveSpeed;

    private void Start()
    {

    }

    virtual public void OnEnable()
    {
        PlayerGold = PlayerPrefs.GetInt("playersGold");
        PlayerBallChance = PlayerPrefs.GetInt("playersBall");
        PlayerSize = PlayerPrefs.GetFloat("playersSize");
    }
    virtual public void OnDisable()
    {
        PlayerPrefs.SetInt("playersGold", PlayerGold);
        PlayerPrefs.SetInt("playersBall", PlayerBallChance);
        PlayerPrefs.SetFloat("playersSize", PlayerSize);

    }

    
    
}
