using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gold : item
{
    // Start is called before the first frame update
    public GameObject PopUp;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Vector2 vector2 = new Vector2(1,1);
        rb.AddForce(vector2*pushForce);
        Effect = GetComponent<ParticleSystem>();
        audio = GetComponent<AudioSource>();
        ofset = new Vector3(5, 5);
        
    }

    public override void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("player1"))
        {
            Debug.Log("playera gold çarptı");
            p1 = collision.gameObject.GetComponent<Player1>();
            p1.PlayerGold += 5;
            
            Effect.Play();
            audio.Play();
            Destroy(gameObject,2f);
            Instantiate(PopUp, PopUp.transform.position, Quaternion.identity);
            
        }
        if (collision.gameObject.CompareTag("bottom"))
        {
            Debug.Log("yere gold çarptı");
            Destroy(gameObject);
        }
        
    }
}
