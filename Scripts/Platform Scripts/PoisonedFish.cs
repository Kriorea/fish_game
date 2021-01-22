using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PoisonedFish : MonoBehaviour{

public bool Player_fish;



void OnTriggerEnter2D(Collider2D target)
{
    if (target.tag == "Enemy") {
        if(Player_fish) {
            ScoreCountScript.scoreValue = 0;
            Destroy(gameObject);
            SoundManager.instance.GGSound();
            
        GameManager.instance.RestartGame();

        }
    }
}


}


