using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loot : MonoBehaviour {

    private int lootValue;


	// Use this for initialization
	void Start ()
    {
        lootValue = Random.Range(10, 50);
	}
	
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            other.GetComponent<PlayerMovement>().CashGrab(lootValue);
            Destroy(gameObject);
        }
    }
}
