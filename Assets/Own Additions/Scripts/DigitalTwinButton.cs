using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DigitalTwinButton : MonoBehaviour
{
    public GameObject ARcamara;
    public GameObject DTcamara;

    public Button digitalTwinButton;

    public bool digitaltwinactive = true;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = digitalTwinButton.GetComponent<Button>();
        btn.onClick.AddListener(LoadDigitalTwin);

    }

    public void LoadDigitalTwin()
    {
        if (digitaltwinactive == false)
        {
            ARcamara.SetActive(false);
            DTcamara.SetActive(true);
            digitaltwinactive = true;

        }

        else if (digitaltwinactive == true)
        {
            DTcamara.SetActive(false);
            ARcamara.SetActive(true);
            digitaltwinactive = false;

        }
    }

}
