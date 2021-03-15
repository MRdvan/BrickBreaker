using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{
    protected Player1 p1;
    protected Rigidbody2D rb;
    protected int pushForce = 40;
    protected ParticleSystem Effect;
    protected new AudioSource audio;
    protected Vector3 ofset;


    public virtual void OnTriggerEnter2D(Collider2D collision)
    {

    }
}
