using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Exit : MonoBehaviour
{
    public void Start()
    {
        if(SceneManager.GetActiveScene().name == "Fin")Invoke("ExitGame", 3f);
        
    }


    public void ExitGame()
    {
        Application.Quit();
    }
    public void ChangementScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
