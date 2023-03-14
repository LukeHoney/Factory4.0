using UnityEngine;
using game4automation;
using TMPro;

public class MachineEmergenyStopNodeReader : MonoBehaviour
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

    [Header("Outlines")]
    public GameObject green;
    public GameObject red;
    //public GameObject greenlight;
    //public GameObject redlight;
    public GameObject dtgreen;
    public GameObject dtred;

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
            //Debug.Log("Bad Colour ON");
            green.SetActive(false);
            red.SetActive(true);
            dtgreen.SetActive(false);
            dtred.SetActive(true);
            //greenlight.SetActive(false);
            //redlight.SetActive(true);
        }

        else if (dataFromOPCUANode == "True")

        {
            //goodColour;
            //Debug.Log("Good Colour ON");
            green.SetActive(true);
            red.SetActive(false);
            dtgreen.SetActive(true);
            dtred.SetActive(false);
            //greenlight.SetActive(true);
            //redlight.SetActive(false);
        }

        else
        {
            //Debug.Log("No Colour On");
        }
    }
}
