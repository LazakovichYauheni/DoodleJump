using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorDestroy : MonoBehaviour {

    public GameObject player;

	void Update () {
        Transform target = GameObject.FindGameObjectWithTag("Ground").transform;

        if (Vector2.Distance(target.position, player.transform.position) > 6.5)
            Destroy(GameObject.FindGameObjectWithTag("Ground"));
	}
}
