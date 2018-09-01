using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState
{
    TITLE,
    PLAYING,
    MENU,
    GAMEOVER,

}

public enum Weapon
{
    PISTOL,
    DUALWIELD,
    MACHINEGUN,
    SHOTGUN,
    FLAMETHROWER,
}
public class GameManager: MonoBehaviour {

    public static GameManager instance;

    //public int score;
    //public int health;
    //public int cash;

    public Weapon currentWeapon;


	// Use this for initialization
	void Start ()
    {
        instance = this;
	}

    public void Restart()
    {
        Score.instance.score = 0;
        Score.instance.health = 4;
        Score.instance.cash = 0;
        currentWeapon = Weapon.PISTOL;
        //UIManager.instance.UpdateHealth(Score.instance.health);
        //UIManager.instance.UpdateScore(Score.instance.score);
        //UIManager.instance.UpdateCash(Score.instance.cash);
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void MachineGun()
    {
        currentWeapon = Weapon.MACHINEGUN;
    }

    public void DualWield()
    {
        currentWeapon = Weapon.DUALWIELD;
    }

    public void ShotGun()
    {
        currentWeapon = Weapon.SHOTGUN;
    }

    public void FlameThrower ()
    {
        currentWeapon = Weapon.FLAMETHROWER;
    }

    public void PlayerHit()
    {
        Score.instance.health--;
        //UIManager.instance.UpdateHealth(health);
    }

    public void IncrementScore(int scoreBonus)
    {
        Score.instance.score += scoreBonus;
        //UIManager.instance.UpdateScore(score);
    }

    public void IncrementCash (int newCash)
    {
        Score.instance.cash += newCash;
        //UIManager.instance.UpdateCash(cash);
    }
}
