using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBounds : MonoBehaviour
{

    public float min_X = -7.28f, max_X = 7.32f, min_Y = -3.7f, max_Y = 4.23f;
  

    void Update()
    {
      CheckBounds();  
    }
    void CheckBounds () {

    Vector2 temp = transform.position;
        if (temp.y > max_Y)
            temp.y = max_Y;
        if (temp.y < min_Y)
            temp.y = min_Y; 
        if (temp.x > max_X)
            temp.x = max_X;
        if (temp.x < min_X)
            temp.x = min_X;  
        transform.position = temp;


    } // CheckBounds ends





} //class
