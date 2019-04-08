using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redPlatformScript : MonoBehaviour {

    // Use this for initialization
    public GameObject target;
    public GameObject redPlatform;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (target != null)
            Destroy(redPlatform);
    }
}
