using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CancelStockCheak : MonoBehaviour
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
        btn.onClick.AddListener(LoadNewInventory);
    }

    public void LoadNewInventory()
    {
        arstockcanvas.SetActive(false);
        dtstockcanvas.SetActive(false);
        checkInventoryUIButton.SetActive(true);
        cancelcheckInventoryUIButton.SetActive(false);
    }
}
