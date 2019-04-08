using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButton : MonoBehaviour {

    public GameObject PausePanel;   
    public void OnDown()
    {
            
            PausePanel.SetActive(true);
            Time.timeScale = 0;
        
    }

}
