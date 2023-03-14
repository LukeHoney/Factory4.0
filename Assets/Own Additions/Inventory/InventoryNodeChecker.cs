using UnityEngine;
using game4automation;
using TMPro;

public class InventoryNodeChecker : MonoBehaviour
{
    [Header("Factory Machine")]
    public string factoryMachineID;
    public OPCUA_Interface Interface;


    [Header("OPCUA Reader")]
    public string nodeBeingMonitored;
    public string nodeID;

    //public TMP_Text digitalTwinFeedbackTMP;
    public TMP_Text uiFeedbackTMP;
    public string dataFromOPCUANode;

    [Header("panels")]
    
    public GameObject instockpanel;
    public GameObject nostockpanel;
    public GameObject dtinstockpanel;
    public GameObject dtnostockpanel;



    void Start()
    {
        Interface.EventOnConnected.AddListener(OnInterfaceConnected);
        Interface.EventOnConnected.AddListener(OnInterfaceDisconnected);
        Interface.EventOnConnected.AddListener(OnInterfaceReconnect);
    }


    private void OnInterfaceConnected()
    {
        Debug.LogWarning("Connected to Factory Machine " + factoryMachineID);
        var subscription = Interface.Subscribe(nodeID, NodeChanged);
        dataFromOPCUANode = subscription.ToString();
        Debug.LogError(dataFromOPCUANode);
        //digitalTwinRFIDFeedbackTMP.text = RFIDInfo;
        //uiRFIDFeedbackTMP.text = RFIDInfo;        
    }

    private void OnInterfaceDisconnected()
    {
        Debug.LogWarning("Factory Machine " + factoryMachineID + " has disconnected");
    }

    private void OnInterfaceReconnect()
    {
        Debug.LogWarning("Factory Machine " + factoryMachineID + " has reconnected");
    }

    public void NodeChanged(OPCUANodeSubscription sub, object value)
    {
        dataFromOPCUANode = value.ToString();
        Debug.LogError("Factory machine " + factoryMachineID + " just registered " + nodeBeingMonitored + " as " + dataFromOPCUANode);
    }


    private void Update()
    {
        //uiFeedbackTMP.text = "Factory machine " + factoryMachineID + " just registered " + nodeBeingMonitored + " as " + dataFromOPCUANode;

        if (dataFromOPCUANode == "False")
        {
            //badColour;
            //Debug.Log("No more Covers");
            
            nostockpanel.SetActive(true);
            instockpanel.SetActive(false);
            dtnostockpanel.SetActive(true);
            dtinstockpanel.SetActive(false);

        }

        else if (dataFromOPCUANode == "True")

        {
            //goodColour;
            //Debug.Log("Good Colour ON");
            nostockpanel.SetActive(false);
            instockpanel.SetActive(true);

        }

        else
        {
            //Debug.Log("No Colour On");
        }
    }
}
