using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour {
    internal static object main;
    public Transform target;
    void LateUpdate()
    {
        if (target.position.y > transform.position.y)
        {
            Vector3 newPos = new Vector3(transform.position.x, target.position.y, transform.position.z);
            transform.position = newPos;
        }
    }

    internal Vector3 WorldToViewportPoint(Vector3 position)
    {
        throw new NotImplementedException();
    }
}
