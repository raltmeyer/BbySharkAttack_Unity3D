using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallsBehaviourScript : MonoBehaviour
{
    Vector3 originalPosition;
    int direction;

    void Start()
    {
        originalPosition = transform.position; // We store the current position
        direction = 0;
    }

    void Update()
    {
        if (direction == 0)
        {
            if (originalPosition.y > -5F)
            {
                originalPosition.y -= 0.5F * Time.deltaTime;
            } else
            {
                direction = 1;
            }
        } else {  //direction=1
            if (originalPosition.y < 0F)
            {
                originalPosition.y += 0.5F * Time.deltaTime;
            }
            else
            {
                direction = 0;
            }
        }

        transform.position = originalPosition;

    }




}
