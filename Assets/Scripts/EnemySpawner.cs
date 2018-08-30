using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    public float spawnTime1 = 5F;
    public float spawnTime2 = 5F;
    public float spawnTime3 = 5F;

    public Vector3 minArea;
    public Vector3 maxArea;

    public GameObject enemyTemplate;
    public GameObject enemyTemplate2;
    public GameObject enemyTemplate3;

    private float currentSpawnTime1 = 0F;
    private float currentSpawnTime2 = 0F;
    private float currentSpawnTime3 = 0F;
    public GameObject player;
    public GameObject waveOver;
    private PlayerMovement _playerMovement;
    public int maxSpawn;
    public int currentSpawn;
    public int countDown;

	// Use this for initialization
	void Start ()
    {
        _playerMovement = GameObject.Find("Player").GetComponent<PlayerMovement>();
        waveOver.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update ()
    {
        currentSpawnTime1 += Time.deltaTime;
        currentSpawnTime2 += Time.deltaTime;
        currentSpawnTime3 += Time.deltaTime;


        if (currentSpawnTime1 >= spawnTime1)
        {
            //Spawn();

            if (!_playerMovement.isDead && currentSpawn < maxSpawn)
            {
                Spawn();
            }
        }

        if (currentSpawnTime2 >= spawnTime2)
        {
            //Spawn();

            if (!_playerMovement.isDead && currentSpawn < maxSpawn)
            {
                Spawn();
            }
        }

        if (currentSpawnTime3 >= spawnTime3)
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

        if (countDown <=0)
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
        Vector3 sPosition = new Vector3(Random.Range(min.x, max.x), Random.Range(min.y, max.y), Random.Range(min.z, max.z));
        Vector3 tPosition = new Vector3(Random.Range(min.x, max.x), Random.Range(min.y, max.y), Random.Range(min.z, max.z));
        float dist = Vector3.Distance(rPosition, player.transform.position);
        float dist2 = Vector3.Distance(sPosition, player.transform.position);
        float dist3 = Vector3.Distance(tPosition, player.transform.position);

        if (dist > 2)
        {
            if(currentSpawnTime1 >= spawnTime1)
            {
                Instantiate(enemyTemplate, rPosition, Quaternion.identity);
                //instantiate enemy according to timer at rPosition;
                currentSpawnTime1 = 0F;
            }
            
        }

        if (dist2 > 3)
        {
            if (currentSpawnTime2 >= spawnTime2)
            {
                Instantiate(enemyTemplate2, sPosition, Quaternion.identity);
                //instantiate enemy according to timer at sPosition;
                currentSpawnTime2 = 0F;
            }
                
        }

        if (dist3 > 4)
        {
            if (currentSpawnTime3 >= spawnTime3)
            {
                Instantiate(enemyTemplate3, tPosition, Quaternion.identity);
                //instantiate enemy according to timer at tPosition;
                currentSpawnTime3 = 0F;
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
