using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {

    public string action;
    private void OnMouseUpAsButton()
    {
        switch (action)
        {
            case "play":
                Application.LoadLevel("SampleScene");
                break;
            case "settings":
                Application.LoadLevel("settings");
                break;
            case "rating":
                Application.LoadLevel("rating");
                break;
            case "select":
                Application.LoadLevel("selectLevel");
                break;
            case "exit":
                Application.Quit();
                break;
            case "back":
                Application.LoadLevel("menu");
                Time.timeScale = 1;
                break;            
        }
    }
}
