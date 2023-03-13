using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quitbutton : MonoBehaviour
{
    public Button quitButton;

    void Start()
    {
        Button btn = quitButton.GetComponent<Button>();
        btn.onClick.AddListener(LoadQuit);

    }
    public void LoadQuit()
    {
        { 
            Application.Quit();
        }
    }
    
}
