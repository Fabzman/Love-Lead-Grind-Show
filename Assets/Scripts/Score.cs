using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : Singleton <Score> {

    public int score = 0;
    public int cash = 0;
    public int health = 4;

    public bool gun = true;
    public bool shotGun = false;
    public bool flameThrower = false;
    public bool machineGun = false;



}
