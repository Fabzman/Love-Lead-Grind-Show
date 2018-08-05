﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

    void Start()
    {
        
    }

    public void LoadStage (int Stage)
    {
        SceneManager.LoadScene(Stage);
    }

    public void QuitGame ()
    {
        Application.Quit();
    }
}
