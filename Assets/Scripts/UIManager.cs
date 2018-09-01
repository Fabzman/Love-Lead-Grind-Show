using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public GameObject startPanel;
    public GameObject inGamePanel;
    public GameObject pauseMenu;
    public GameObject waveComplete;
    public GameObject gameOver;
    public static UIManager instance;
    //public int score;
    //public int life;
    private PlayerMovement _playerHealth;
    //private EnemySpawner;
    //public static int enemyCount;
    //public static int lifeCount;
    //public static int cashCount;
    //public static int bossHealth;

    //Score Text
    public Text scoreText;
    //Health Text
    public Text healthText;
    //Cash text
    public Text cashText;
    //Boss health Text
    public Text bossText;

    void Awake()
    {
        instance = this;
    }
	// Use this for initialization
	void Start ()
    {
        //score = 0;
        //life = 4;
        //lifeCount = 4;
        //bossHealth = 100;
	}
	
	// Update is called once per frame
	void Update ()
    {
        scoreText.text = "Score: " + Score.instance.score;
        healthText.text = "Life: " + Score.instance.health;
        cashText.text = "Cash: " + Score.instance.cash;
        //bossText.text = "Boss: " + bossHealth;
    }

    // Causes more trouble than worth
    //public void UpdateHealth(int newHealth)
    //{
    //    healthText.text = "Life: " + newHealth;
    //}

    //public void UpdateScore (int newScore)
    //{
    //    scoreText.text = "Score: " + newScore;
    //}

    //public void UpdateCash (int newCash)
    //{
    //    cashText.text = "Cash: " + newCash;
    //}

    public void UpdateBoss(int newBossHealth)
    {
        bossText.text = "Boss: " + newBossHealth;
    }

    public void Restart()
    {
        gameOver.SetActive(false);
        GameManager.instance.Restart();
    }
}
