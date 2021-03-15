using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuManager : MonoBehaviour
{
    
    private void Start()
    {
        
    }

    public void Load(int index)
    {
        if (index == 1)
        {
            PlayerPrefs.DeleteAll();

            PlayerPrefs.SetInt("playersGold", 0);
            PlayerPrefs.SetInt("playersBall", 3);
            PlayerPrefs.SetFloat("playersSize", 1);
        }
        SceneManager.LoadScene(index);

    }

    public void Quit()
    {
        Application.Quit();
    }
}
