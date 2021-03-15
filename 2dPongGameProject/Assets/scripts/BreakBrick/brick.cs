using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class brick : MonoBehaviour
{
    public int life;
    public Material lwl1;
    public Material lwl2;
    public AudioSource BreakBrickSound;
    public AudioSource hitsound;
    public GameObject be;
    public ParticleSystem breakingEffect;
    public GameObject gold;
    public GameObject extraLife;


    private void Start()
    {
        breakingEffect = FindObjectOfType<ParticleSystem>();
        //hitsound = gameObject.GetComponent<AudioSource>();

        //be = GameObject.Find("breakingEffect");
        //breakingEffect = be.GetComponent<ParticleSystem>();
    }

    public virtual void ChangeColor()
    {
        //2 canlı brick için renk değiştirme
        switch (this.life)
        {
            case 2: gameObject.GetComponent<Renderer>().material = lwl2; break;
            case 1: gameObject.GetComponent<Renderer>().material = lwl1; break;
            case 0:
                break;
        }

    }

    public virtual void ballHit()
    {
        playSound();

        life--;// minus 1 health of brick

        ChangeColor();// change color  // after 3 hit brick destroy
        if (life == 0)
        {
            playParentSound();
            breakingEffect.transform.position = transform.position;
            breakingEffect.Play();
            Destroy(gameObject, breakingEffect.main.duration);
            spawnItem(gold, UnityEngine.Random.Range(0, 3));//%33 chance
            spawnItem(extraLife, UnityEngine.Random.Range(0, 5));//% 20 chance
            // summon a ball chance (%5)
        }
    }

    public virtual void spawnItem(GameObject item,int spawnChance)
    {
        UnityEngine.Random.Range(0, 2); //%25 chance
        Debug.Log("goldchance: " + spawnChance);
        if (spawnChance == 1)
        {
            Instantiate(item, transform.position, transform.rotation); //spawn a coin
        }
    }

    public virtual void playSound()//parçalanma sesi
    {
        hitsound = gameObject.GetComponent<AudioSource>();
        hitsound.Play();
    }

    public virtual void playParentSound()//çatlama sesi
    {
        hitsound = gameObject.GetComponentInParent<AudioSource>();
        hitsound.Play();
    }

    
}