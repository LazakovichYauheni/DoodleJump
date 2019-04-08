using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Die : MonoBehaviour {

    public GameObject PanelLost;
    private BoxCollider2D box;
    public GameObject Hero;
    // Use this for initialization
	void Start () {
        box = GetComponent<BoxCollider2D>();   
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D () {
        if (Hero != null)
        {
            Destroy(Hero);
            PanelLost.SetActive(true);
            float score = GetComponent<Score>().score;
            if (PlayerPrefs.GetFloat("Score") < score)
                PlayerPrefs.SetFloat("Score", score);
        }
	}
}
