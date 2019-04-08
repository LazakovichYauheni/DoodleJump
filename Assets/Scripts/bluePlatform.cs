using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bluePlatform : MonoBehaviour {

    bool moveRight = true;
    float speed = 3f; //unit per second

    void Update()
    {
        if (moveRight)
        {
            var pos = transform.position;
            pos.x += speed * Time.deltaTime;
            transform.position = pos;
            if (pos.x > 1f) moveRight = false;
        }
        else
        {
            var pos = transform.position;
            pos.x -= speed * Time.deltaTime;
            transform.position = pos;
            if (pos.x < -1f) moveRight = true;
        }
    }
}
