using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    //public int score;
    //public int life;
    private PlayerMovement _playerHealth;
    //private EnemySpawner ;
    public static int enemyCount;
    public static int lifeCount;

    //hate not understanding this
    //Score Text
    public Text scoreText;
    //Health Text
    public Text healthText;


	// Use this for initialization
	void Start ()
    {
        //score = 0;
        //life = 4;
        lifeCount = 4;
	}
	
	// Update is called once per frame
	void Update ()
    {
        scoreText.text = "Score: " + enemyCount;
        healthText.text = "Life: " + lifeCount;
	}
}
