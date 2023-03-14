using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CancelCheckConnection : MonoBehaviour
{
    public Button checkconnectionButton;

    public GameObject greenOutline;
    public GameObject dtgreenOutline;

    public GameObject CheckConnButton;

    public GameObject CancelCheckConnectionButton;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = checkconnectionButton.GetComponent<Button>();
        btn.onClick.AddListener(LoadConnection);
    }

    public void LoadConnection()
    {
        greenOutline.SetActive(false);
        dtgreenOutline.SetActive(false);
        CheckConnButton.SetActive(true);
        CancelCheckConnectionButton.SetActive(false);
    }
}
