using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firePoint : MonoBehaviour
{
    Player1 p1;

    void Start()
    {
        p1 = FindObjectOfType<Player1>();
    }

    // Update is called once per frame
    void Update()
    {
        // fire point position
        transform.position = new Vector2(p1.transform.position.x, p1.transform.position.y +0.6f);
    }
}
