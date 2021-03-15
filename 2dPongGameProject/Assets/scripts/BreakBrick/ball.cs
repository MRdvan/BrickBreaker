using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ball : MonoBehaviour {

	Rigidbody2D rb;
	public Player1 p1;
	public float moveSpeed;
	brick brick;
	AudioSource hitsound;
	
	// Use this for initialization
	void Start () {
		brick.FindObjectOfType<brick>();
		rb = GetComponent<Rigidbody2D>();
		p1 = FindObjectOfType<Player1>();
		//rb.velocity = firepoint.up * moveSpeed;
	}

    [System.Obsolete]
    void OnCollisionEnter2D(Collision2D collision)
    {
		if (collision != null)
		{
			// collision sound
			// collision effect
			// collision kontrolu player için

			if (collision.gameObject.CompareTag("player1")) 
			{
				Debug.Log("player a çarptı");
				
				playSound();//çarpma sesi
				
				float dist = this.transform.position.x - collision.gameObject.transform.position.x; // topun çarptığı yere göre uzaklık alma
				Debug.Log(dist);
				if(dist > 1.0f) // sağa hız sabitlemesi
                {
					dist = 0.9f;
                }
				if(dist < -1.0f) // sola hız sabitlemesi
                {
					dist = -0.9f;
				}
				Debug.Log(dist);
				rb.velocity = new Vector2(dist, 0)*moveSpeed + new Vector2(0, 1) *moveSpeed; // yönünü belirleme ve yollama

			}
			if (collision.gameObject.CompareTag("wall"))
			{
				playSound();
			}
				
			if (collision.gameObject.CompareTag("brick"))// collision kontrolu brick için
			{
				collision.gameObject.GetComponent<brick>().ballHit();
			}
			
			if (collision.gameObject.CompareTag("HardBrick"))// collision kontrolu HardBrick için
			{
				collision.gameObject.GetComponent<HardBrick>().ballHit();
			}
			if (collision.gameObject.CompareTag("bottom"))
			{
				Debug.Log("alta çarptı");
				Destroy(gameObject);
				p1.PlayerBallChance--;
				// ball left güncelle
				p1.PlayersCurrentBallNumber = 0;
			}
		}

		void playSound()//parçalanma sesi
		{
			hitsound = collision.gameObject.GetComponent<AudioSource>();
			hitsound.Play();
		}
	}

}
