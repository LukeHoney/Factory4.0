using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContinueButton : MonoBehaviour
{
    public Button continueButton;

    public GameObject thankyoupanel;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = continueButton.GetComponent<Button>();
        btn.onClick.AddListener(LoadContinue);
    }

    public void LoadContinue()
    {
        thankyoupanel.SetActive(false);
    }
}
