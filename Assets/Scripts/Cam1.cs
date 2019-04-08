using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cam1 : MonoBehaviour {

    public float speed = 3f;
    void Update()
    {
        gameObject.transform.position += gameObject.transform.up * speed * Time.deltaTime;
        
    }
    
}
