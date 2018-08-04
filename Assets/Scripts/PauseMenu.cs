using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

    public GameObject pauseMenu;

	// Use this for initialization
	void Start ()
    {
        pauseMenu.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (Input.GetKeyDown(KeyCode.Escape))
        {
            //pause = true;
            pauseMenu.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
	}

    public void unPause()
    {
        pauseMenu.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}
