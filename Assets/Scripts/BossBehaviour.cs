using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBehaviour : MonoBehaviour {

    private PlayerMovement _player;
    private BossSpawner _spawn;
    public float enemySpeed;
    public int bossHealth;
    public bool bossDead;
    public Transform player;
    public GameObject loot;
    public int scoreBonus = 5000;

    // Use this for initialization
    void Start()
    {
        _player = GameObject.Find("Player").GetComponent<PlayerMovement>();
        _spawn = GameObject.Find("EnemySpawner").GetComponent<BossSpawner>();
        _spawn.currentSpawn++;
        player = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        float step = enemySpeed * Time.deltaTime;

        transform.position = Vector3.MoveTowards(transform.position, player.position, step);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Shot")
        {
            bossHealth --;
            Destroy(GameObject.FindGameObjectWithTag("Shot"));
            UIManager.instance.UpdateBoss(bossHealth);

            if (bossHealth <= 65)
            {
                enemySpeed = 5;
            }

            if (bossHealth <= 25)
            {
                enemySpeed = 8;
            }

            if (bossHealth <= 0)
            {
                bossDead = true;
                bossHealth = 0;

                if (bossDead)
                {
                    _spawn.currentSpawn--;
                    _spawn.maxSpawn--;
                    // UIManager.enemyCount += 5000;
                    GameManager.instance.IncrementScore(scoreBonus);
                    Instantiate(loot, transform.position, transform.rotation);
                    Destroy(gameObject);
                }
            }
            
        }

        if (other.tag == "Player")
        {
            GameManager.instance.PlayerHit();
            //Destroy(GameObject.FindGameObjectWithTag("Player"));
            //_player.playerHealth--;
            //UIManager.lifeCount--;
        }

        else if (other.tag == "Boundary")
        {
            return;
        }

    }
}
