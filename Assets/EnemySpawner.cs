using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    public float spawnTime = 5F;

    public Vector3 minArea;
    public Vector3 maxArea;

    public GameObject enemyTemplate;

    private float currentSpawnTime = 0F;

	// Use this for initialization
	void Start ()
    {
	}
	
	// Update is called once per frame
	void Update ()
    {
        currentSpawnTime += Time.deltaTime;


        if (currentSpawnTime >= spawnTime)
        {
            Vector3 min = transform.position + minArea;
            Vector3 max = transform.position + maxArea;

            Vector3 rPosition = new Vector3(Random.Range(min.x, max.x), Random.Range(min.y, max.y), Random.Range(min.z, max.z));

            //instantiate enemy according to timer at rPosition;
            Instantiate(enemyTemplate, rPosition, Quaternion.identity);

            currentSpawnTime = 0F;
        }
    }

    private void OnDrawGizmos()
    {
        Vector3 min = transform.position + minArea;
        Vector3 max = transform.position + maxArea;

        Gizmos.color = Color.magenta;
        Gizmos.DrawWireCube(Vector3.Lerp(min, max, 0.5F), max - min);
    }
}
