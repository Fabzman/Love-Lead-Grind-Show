using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loot : MonoBehaviour {

    private int lootValue;
    public float spinSpeed;


	// Use this for initialization
	void Start ()
    {
        //lootValue = Random.Range(1, 10);
        lootValue = 10;
	}

    private void Update()
    {
        transform.Rotate(Vector3.up, spinSpeed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            GameManager.instance.IncrementCash(lootValue);
            //other.GetComponent<PlayerMovement>().CashGrab(lootValue);
            Destroy(gameObject);
            //UIManager.cashCount += lootValue;
        }
    }
}
