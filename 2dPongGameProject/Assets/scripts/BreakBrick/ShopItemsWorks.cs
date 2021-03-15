using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopItemsWorks : MonoBehaviour
{
    public PlayerInfo playerInfo;
    // Start is called before the first frame update
    private void Start()
    {
    }
    private void OnEnable()
    {
        playerInfo.PlayerSize = PlayerPrefs.GetFloat("playersSize");
        playerInfo.PlayerGold = PlayerPrefs.GetInt("playersGold");
        playerInfo.PlayerBallChance = PlayerPrefs.GetInt("playersBall");

    }
    private void OnDisable()
    {
        PlayerPrefs.SetFloat("playersSize", playerInfo.PlayerSize);
        PlayerPrefs.SetInt("playersGold",playerInfo.PlayerGold);
        PlayerPrefs.SetInt("playersBall", playerInfo.PlayerBallChance);
    }
    
    public void increseSize()
    {
        if(playerInfo.PlayerGold >= 50)
        {
            
            playerInfo.PlayerGold -= 50; // decrease gold
            Debug.Log("playersize :" + playerInfo.PlayerSize);
            playerInfo.PlayerSize++;
            Debug.Log("playersize :" + playerInfo.PlayerSize);
        }
        else
        {
            Debug.Log("you need" + (50-playerInfo.PlayerGold) + "gold more to buy this !!");
        }
        
    }

    public void AddBallToPlayer()
    {
        if(playerInfo.PlayerGold >= 10)
        {
            playerInfo.PlayerGold -= 10;  //decrease gold
            playerInfo.PlayerBallChance++;
        }
        else
        {
            Debug.Log("you need" + (10- playerInfo.PlayerGold) + "gold more to buy this !!");
        }
    }
}
