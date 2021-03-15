using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AllBricks : MonoBehaviour
{
    public int totalBrick;
    public AudioSource breakingSound;
    public Text Bricktext;

    private void Start()
    {
        totalBrick = gameObject.transform.childCount;
    }
    private void Update()
    {
        totalBrick = gameObject.transform.childCount;
        Bricktext.text = totalBrick.ToString();
    }
}
