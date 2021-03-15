using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class homeManager : MonoBehaviour
{
    Player1 p1;
    public Text ballText, goldText;
    // Start is called before the first frame update
    void Start()
    {
        p1 = FindObjectOfType<Player1>();
        ballText.text = p1.PlayerBallChance.ToString();
        goldText.text = p1.PlayerGold.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
