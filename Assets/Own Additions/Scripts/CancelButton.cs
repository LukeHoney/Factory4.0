using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CancelButton : MonoBehaviour
{
    public Button sendOrderButton;

    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = sendOrderButton.GetComponent<Button>();
        btn.onClick.AddListener(LoadCancel);
    }

    public void LoadCancel()
    {
        panel.SetActive(false);
    }
}