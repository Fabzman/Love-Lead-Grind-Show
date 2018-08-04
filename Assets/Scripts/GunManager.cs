using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunManager : MonoBehaviour {

    public bool isShooting;
    public BulletManager shot;
    public float bulletSpeed;
    public float nextShot;
    public float shotTimer;
    public Transform barrelPoint;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (isShooting)
        {
            shotTimer -= Time.deltaTime;

            if (shotTimer <= 0)
            {
                shotTimer = nextShot;
                BulletManager newBullet = Instantiate(shot, barrelPoint.position, barrelPoint.rotation) as BulletManager;
                newBullet.bulletSpeed = bulletSpeed;
            }
        }

        else
        {
            shotTimer = 0;
        }
	}
}
