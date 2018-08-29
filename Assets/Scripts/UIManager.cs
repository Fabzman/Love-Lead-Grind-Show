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
    public static int cashCount;
    public static int bossHealth;

    //Score Text
    public Text scoreText;
    //Health Text
    public Text healthText;
    //Cash text
    public Text cashText;
    //Boss health Text
    public Text bossText;


	// Use this for initialization
	void Start ()
    {
        //score = 0;
        //life = 4;
        lifeCount = 4;
        bossHealth = 100;
	}
	
	// Update is called once per frame
	void Update ()
    {
        scoreText.text = "Score: " + enemyCount;
        healthText.text = "Life: " + lifeCount;
        cashText.text = "Cash: " + cashCount;
        bossText.text = "Boss: " + bossHealth;
	}
}
