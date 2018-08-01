using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {       
        if (other.tag == "Shot")
        {
            Destroy(GameObject.FindGameObjectWithTag("Shot"));
            Destroy(gameObject);
        }

        else if (other.tag == "Boundary")
        {
            return;
        }

    }
}
