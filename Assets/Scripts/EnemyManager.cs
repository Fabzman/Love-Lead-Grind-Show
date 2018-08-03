using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {

    private PlayerMovement _player;
    private EnemySpawner _spawn;
    public float enemySpeed;
    public Transform player;

	// Use this for initialization
	void Start ()
    {
        _player = GameObject.Find("Player").GetComponent<PlayerMovement>();
        _spawn = GameObject.Find("EnemySpawner").GetComponent<EnemySpawner>();
        _spawn.currentSpawn++;
        player = GameObject.Find("Player").transform;
    }
	
	// Update is called once per frame
	void Update ()
    {
        float step = enemySpeed * Time.deltaTime;

        transform.position = Vector3.MoveTowards(transform.position, player.position, step);
    }

    private void OnTriggerEnter(Collider other)
    {       
        if (other.tag == "Shot")
        {
            Destroy(GameObject.FindGameObjectWithTag("Shot"));
            Destroy(gameObject);
            _spawn.currentSpawn --;
            _spawn.maxSpawn--;
            UIManager.enemyCount+=100;
        }

        if (other.tag == "Player")
        {
            //Destroy(GameObject.FindGameObjectWithTag("Player"));
            _player.playerHealth --;
            UIManager.lifeCount--;
        }

        else if (other.tag == "Boundary")
        {
            return;
        }

    }
}
