using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StockScript : MonoBehaviour
{
    public Button checkInventoryButton;

    public GameObject arstockcanvas;
    public GameObject dtstockcanvas;

    //public GameObject checkInventoryUIButton;
    //public GameObject cancelcheckInventoryUIButton;

    public bool notcheckingstock = true;

    // Start is called before the first frame update
    void Start()
    {
        //Button btn = checkInventoryButton.GetComponent<Button>();
        //btn.onClick.AddListener(LoadStock);
    }

    public void LoadStock()
    {
        if (notcheckingstock == false)
        {
            arstockcanvas.SetActive(true);
            dtstockcanvas.SetActive(true);
            //checkInventoryUIButton.SetActive(false);
            //cancelcheckInventoryUIButton.SetActive(true);
            notcheckingstock = true;
            Debug.Log("stockcheck set active pressed");
        }

        else if (notcheckingstock == true)
        {
            arstockcanvas.SetActive(false);
            dtstockcanvas.SetActive(false);
            //checkInventoryUIButton.SetActive(false);
            //cancelcheckInventoryUIButton.SetActive(true);
            notcheckingstock = false;
            Debug.Log("stockcheck deactive pressed");
        }
    }
}
