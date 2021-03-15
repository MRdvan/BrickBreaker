using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : PlayerInfo
{
    // Start is called before the first frame update
 
    Rigidbody2D rb;
    public bool isShooting = false;

    public int PlayersCurrentBallNumber = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        PlayerSize = PlayerPrefs.GetFloat("playersSize");
        transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y + PlayerSize, transform.localScale.z);
    }

    void Update()
    {
        if(isShooting == false)
        {
            // sağa ve sola hareketi sağlıyor
            float moveHorizontal = Input.GetAxis("Horizontal") * moveSpeed;
            rb.velocity = new Vector2(moveHorizontal, 0);
        }
    }
    public override void OnEnable()
    {
        base.OnEnable();
    }

    public override void OnDisable()
    {
        base.OnDisable();
    }
}
