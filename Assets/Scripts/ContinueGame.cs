using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueGame : MonoBehaviour {
    public GameObject PausePanel;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void Continue()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1;
    }
}
