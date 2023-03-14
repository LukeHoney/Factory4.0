using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CancelStockCheak : MonoBehaviour
{
    public Button checkInventoryButton;

    public GameObject scriptholder;

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
        scriptholder.SetActive(false);
        checkInventoryUIButton.SetActive(true);
        cancelcheckInventoryUIButton.SetActive(false);
    }
}
