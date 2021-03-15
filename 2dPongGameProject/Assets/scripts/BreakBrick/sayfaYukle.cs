using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sayfaYukle : MonoBehaviour
{
    public int sceneWantToGo;

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ball"))
        {
            SceneManager.LoadScene(sceneWantToGo);
        }
    }
}
