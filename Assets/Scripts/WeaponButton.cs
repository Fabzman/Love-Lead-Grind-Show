using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponButton : MonoBehaviour {

    //public bool machineGun;
    //public bool shotGun;
    //public bool flameThrower;
    public GameObject gun;
    public GameObject machineGun;
    public GameObject shotGun;
    public GameObject flameThrower;
    public bool Powerup1;
    public bool Powerup2;
    public bool Powerup3;
    //public Score cash;

    public void Start()
    {
        //machineGun = false;
        //shotGun = false;
        //flameThrower = false;
        gun.gameObject.SetActive(true);
        machineGun.gameObject.SetActive(false);
        shotGun.gameObject.SetActive(false);
        flameThrower.gameObject.SetActive(false);
        Powerup1 = false;
        Powerup2 = false;
        Powerup3 = false;
    }

    public void Update()
    {
        if (Score.instance.cash >= 200)
        {
            Powerup1 = true;
        }

        if (Score.instance.cash >= 200)
        {
            Powerup2 = true;
        }

        if (Score.instance.cash >= 200)
        {
            Powerup3 = true;
        }
    }


    public void MachineGun()
{
    if (Powerup1)
    {
            Score.instance.gun = false;
            Score.instance.shotGun = false;
            Score.instance.flameThrower = false;
            Score.instance.machineGun = true;
            //gun.gameObject.SetActive(false);
            //shotGun.gameObject.SetActive(false);
            //flameThrower.gameObject.SetActive(false);
            //machineGun.gameObject.SetActive(true);
            Score.instance.cash -= 200;
        }
}

public void Shotgun()
{
    if (Powerup2)
    {
            Score.instance.gun = false;
            Score.instance.shotGun = true;
            Score.instance.flameThrower = false;
            Score.instance.machineGun = false;
            //gun.gameObject.SetActive(false);
            //machineGun.gameObject.SetActive(false);
            //flameThrower.gameObject.SetActive(false);
            //shotGun.gameObject.SetActive(true);
            Score.instance.cash -= 200;
        }
}

public void FlameThrower()
{
    if (Powerup3)
    {
            Score.instance.gun = false;
            Score.instance.shotGun = false;
            Score.instance.flameThrower = true;
            Score.instance.machineGun = false;
            //gun.gameObject.SetActive(false);
            //machineGun.gameObject.SetActive(false);
            //shotGun.gameObject.SetActive(false);
            //flameThrower.gameObject.SetActive(true);
            Score.instance.cash -= 200;
        }
}

//public void MachineGun()
//{
//    GameManager.instance.MachineGun();
//}

//public void DualWield()
//{
//    GameManager.instance.DualWield();
//}

//public void ShotGun()
//{
//    GameManager.instance.ShotGun();
//}

//public void FlameThrower()
//{
//    GameManager.instance.FlameThrower();
//}


}
