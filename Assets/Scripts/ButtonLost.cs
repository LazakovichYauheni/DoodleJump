using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonLost : MonoBehaviour {

    public string action1;

    private void OnMouseUpAsButton()
    {
        switch (action1)
        {
            case "again": SceneManager.LoadScene("SampleScene");
                break;
            case "home": SceneManager.LoadScene("menu");
                break;
           
        }
    }
}
