﻿using UnityEngine;

using System.Collections;



public class Destroyer : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)

    {

        if (other.tag == "Ground")

        {

            Destroy(other.gameObject);

        }

    }

}