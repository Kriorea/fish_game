using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawner : MonoBehaviour
{
    public GameObject poisonedFish1;
    public GameObject Fish_2;
    public GameObject poisonedFish3;
    public GameObject Fish_4;
    public GameObject Fish_5;
    public GameObject Fish_6;
    public GameObject poisoned_Fish7;
    public float fish_Spawn_Timer = 1f;
    private float current_fish_Spawn_Timer;

    private int fish_Spawn_Count;
    public float min_Y =-4, max_Y = 4;

    void Start()
    {
      current_fish_Spawn_Timer = fish_Spawn_Timer;
    }

    
    void Update() {
      SpawnFishes();
    }
    void SpawnFishes() {
      current_fish_Spawn_Timer += Time.deltaTime;
      if(current_fish_Spawn_Timer >= fish_Spawn_Timer){
        
          fish_Spawn_Count++;

          Vector3 temp = transform.position;
          temp.y = Random.Range(min_Y, max_Y);
          GameObject newFish = null;
          if(fish_Spawn_Count < 2) {
              if(Random.Range(0,2) > 0) {
                newFish = Instantiate(Fish_4, temp, Quaternion.identity);
              } else {
                newFish = Instantiate(Fish_2, temp, Quaternion.identity);
              }

          } else if(fish_Spawn_Count == 2) {
              if(Random.Range(0,2) > 0) {
                newFish = Instantiate(Fish_5, temp, Quaternion.identity);
              } else {
                newFish = Instantiate(Fish_2, temp, Quaternion.identity);
              }
          }
          else if(fish_Spawn_Count == 3) {
              if(Random.Range(0,2) > 0) {
                newFish = Instantiate(Fish_6, temp, Quaternion.identity);
              } else {
                newFish = Instantiate(Fish_2, temp, Quaternion.identity);
              }
          }
          else if(fish_Spawn_Count == 4) {
              if(Random.Range(0,2) > 0) {
                newFish = Instantiate(poisonedFish1, temp, Quaternion.identity);
              } else {
                newFish = Instantiate(poisonedFish3, temp, Quaternion.identity);
              }
          }
          else if(fish_Spawn_Count == 5) {
              if(Random.Range(0,2) > 0) {
                newFish = Instantiate(poisoned_Fish7, temp, Quaternion.identity);
              } else {
                newFish = Instantiate(Fish_2, temp, Quaternion.identity);
              } fish_Spawn_Count = 0;
          }
          
          current_fish_Spawn_Timer = 0f;
        } //if ends
        
        

    } // spawnFishes end

       
    
    
    

}
