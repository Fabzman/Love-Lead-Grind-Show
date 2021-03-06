﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpawner : MonoBehaviour {

    public float spawnTime = 5F;

    public Vector3 minArea;
    public Vector3 maxArea;

    public GameObject enemyTemplate;

    private float currentSpawnTime = 0F;

    public GameObject player;
    public GameObject waveOver;
    private PlayerMovement _playerMovement;
    public int maxSpawn;
    public int currentSpawn;
    public int countDown;

    // Use this for initialization
    void Start()
    {
        _playerMovement = GameObject.Find("Player").GetComponent<PlayerMovement>();
        waveOver.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        currentSpawnTime += Time.deltaTime;

        if (currentSpawnTime >= spawnTime)
        {
            //Spawn();

            if (!_playerMovement.isDead && currentSpawn < maxSpawn)
            {
                Spawn();
            }
        }

        if (maxSpawn <= 0)
        {
            countDown--;
        }

        if (countDown <= 0)
        {
            countDown = 0;
            waveOver.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }

    void Spawn()
    {
        Vector3 min = transform.position + minArea;
        Vector3 max = transform.position + maxArea;

        Vector3 rPosition = new Vector3(Random.Range(min.x, max.x), Random.Range(min.y, max.y), Random.Range(min.z, max.z));
        float dist = Vector3.Distance(rPosition, player.transform.position);

        if (dist > 3)
        {
            if (currentSpawnTime >= spawnTime)
            {
                Instantiate(enemyTemplate, rPosition, Quaternion.identity);
                //instantiate enemy according to timer at rPosition;
                currentSpawnTime = 0F;
            }

        }

        else
            Spawn();
    }

    private void OnDrawGizmos()
    {
        Vector3 min = transform.position + minArea;
        Vector3 max = transform.position + maxArea;

        Gizmos.color = Color.magenta;
        Gizmos.DrawWireCube(Vector3.Lerp(min, max, 0.5F), max - min);
    }
}
