using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotGun : MonoBehaviour
{

    public bool isShooting;
    public BulletManager shot;
    public float bulletSpeed;
    public float nextShot;
    public float shotTimer;
    public Transform barrelPoint;
    public Transform barrelPoint2;
    public Transform barrelPoint3;
    public Transform barrelPoint4;
    public Transform barrelPoint5;
    // Use this for initialization
    void Start()
    {
        if (name == "Machine Gun" && !Score.instance.machineGun)
            gameObject.SetActive(false);
        else if (name == "Shotgun" && !Score.instance.shotGun)
            gameObject.SetActive(false);
        else if (name == "Flamethrower" && !Score.instance.flameThrower)
            gameObject.SetActive(false);
        else if (name == "Gun" && !Score.instance.gun)
            gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isShooting)
        {
            shotTimer -= Time.deltaTime;

            if (shotTimer <= 0)
            {
                shotTimer = nextShot;
                BulletManager newBullet = Instantiate(shot, barrelPoint.position, barrelPoint.rotation) as BulletManager;
                BulletManager newBullet2 = Instantiate(shot, barrelPoint2.position, barrelPoint2.rotation) as BulletManager;
                BulletManager newBullet3 = Instantiate(shot, barrelPoint3.position, barrelPoint3.rotation) as BulletManager;
                BulletManager newBullet4 = Instantiate(shot, barrelPoint4.position, barrelPoint4.rotation) as BulletManager;
                BulletManager newBullet5 = Instantiate(shot, barrelPoint5.position, barrelPoint5.rotation) as BulletManager;
                newBullet.bulletSpeed = bulletSpeed;
            }
        }

        else
        {
            shotTimer = 0;
        }
    }
}
