using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CheckInventory : MonoBehaviour
{
    public Button checkInventoryButton;

    public GameObject arstockcanvas;
    public GameObject dtstockcanvas;

    public GameObject checkInventoryUIButton;
    public GameObject cancelcheckInventoryUIButton;


    // Start is called before the first frame update
    void Start()
    {
        Button btn = checkInventoryButton.GetComponent<Button>();
        btn.onClick.AddListener(LoadInventory);
    }

    public void LoadInventory()
    {
        arstockcanvas.SetActive(true);
        dtstockcanvas.SetActive(true);
        checkInventoryUIButton.SetActive(false);
        cancelcheckInventoryUIButton.SetActive(true);
    }
}
