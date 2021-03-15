using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameControl : MonoBehaviour
{
    Player1 p1;
    brick brick;
    AllBricks allBricks;
    public Text ballText, goldText, levelText;
    void Start()
    {
        
        p1 = FindObjectOfType<Player1>();
        brick = FindObjectOfType<brick>();
        allBricks = FindObjectOfType<AllBricks>();
        WritePrefs();
    }

    // Update is called once per frame
    void Update()
    {
        WritePrefs();

        if (p1.PlayerBallChance == 0)
        {
            SceneManager.LoadScene(1);
            // YOU LOST repeat level

        }
        if(allBricks.totalBrick == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            //levelText.text = SceneManager.GetActiveScene().buildIndex.ToString();
        }
        if (Input.GetKey(KeyCode.Escape) && p1.PlayersCurrentBallNumber == 0)
        {
            SceneManager.LoadScene(1);
        }

    }

    public void WritePrefs()
    {
        ballText.text = p1.PlayerBallChance.ToString();
        goldText.text = p1.PlayerGold.ToString();
        levelText.text = (SceneManager.GetActiveScene().buildIndex-3).ToString();
    }
}
