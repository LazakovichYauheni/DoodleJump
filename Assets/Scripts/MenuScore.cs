using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScore : MonoBehaviour {

    // Use this for initialization
    public Text txt;
	void Start () {
            
        GetComponent<Text>().text = PlayerPrefs.GetFloat("Score").ToString();
        if (txt.text.IndexOf('.') != -1)
            txt.text = txt.text.Remove(txt.text.IndexOf('.'));
        PlayerPrefs.DeleteAll();
    }
	
	
}
