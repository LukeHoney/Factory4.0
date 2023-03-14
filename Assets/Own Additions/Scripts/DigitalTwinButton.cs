using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DigitalTwinButton : MonoBehaviour
{
    public GameObject ARcamara;
    public GameObject DTcamara;

    public GameObject ARtext;
    public GameObject DTtext;

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
            ARtext.SetActive(false);
            DTtext.SetActive(true);
            digitaltwinactive = true;

        }

        else if (digitaltwinactive == true)
        {
            DTcamara.SetActive(false);
            ARcamara.SetActive(true);
            DTtext.SetActive(false);
            ARtext.SetActive(true);
            digitaltwinactive = false;

        }
    }

}
