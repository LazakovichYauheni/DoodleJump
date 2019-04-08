using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public float score;
    public Transform target;
    public Text txt;
    
	// Use this for initialization
	void Start () {
        target = GameObject.FindGameObjectWithTag("Hero").transform;
	}
	
	// Update is called once per frame
	void Update () {
        EnterScore();
	}

    void EnterScore()
    {
        if (target.position.y > score)
            score = target.position.y;

        txt.text = score.ToString();

        if (txt.text.IndexOf('.') != -1)
            txt.text = txt.text.Remove(txt.text.IndexOf('.'));
    }
    

}
