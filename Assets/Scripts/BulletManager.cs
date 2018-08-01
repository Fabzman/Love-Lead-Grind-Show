using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour {

    public float bulletSpeed;
    public float lifetime;


	// Use this for initialization
	void Start ()
    {
        Destroy(gameObject, lifetime);
	}
	
	// Update is called once per frame
	void Update ()
    {
        //makes the bullet go whoosh
        transform.Translate(Vector3.forward * bulletSpeed * Time.deltaTime);
	}
}
