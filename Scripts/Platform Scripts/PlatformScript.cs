using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{
   public float move_Speed = 2f;
   public float bound_X = 7f;
   public bool poisonedFish1, Fish_2, poisonedFish3, Fish_4, Fish_5, Fish_6, poisoned_Fish7;

   public GameObject Player_fish;


    void Start()
    {
        
    }

    
    void Update()
    {
        Move();
    }
    void Move() {

        transform.Translate(new Vector2(-1,0) * Time.deltaTime * move_Speed);

        if (transform.position.x <-10)
        {
            Destroy(gameObject);
        }
    } //move ends


void OnTriggerEnter2D(Collider2D target)
{
    if(target.tag == "Player") {
        if(Fish_2) {
            ScoreCountScript.scoreValue += 3;
            Destroy(gameObject);
            SoundManager.instance.EatSound();
        }
        else if (Fish_4) {
            ScoreCountScript.scoreValue += 1;
            Destroy(gameObject);
            SoundManager.instance.EatSound();
        }
        else if (Fish_5) {
            ScoreCountScript.scoreValue += 2;
            Destroy(gameObject);
            SoundManager.instance.EatSound();
        }
        else if (Fish_6) {
            ScoreCountScript.scoreValue += 1;
            Destroy(gameObject);
            SoundManager.instance.EatSound();
        }
        
    }
}





}
