using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using game4automation;
using TMPro;

public class TrackingCarts : MonoBehaviour
{
    [Header("Factory Machine")]
    public string factoryMachineID;
    public OPCUA_Interface Interface;

    [Header("OPCUA Reader")]
    public string nodeBeingMonitored;
    public string nodeID;

    [Header("Carts")]
    public GameObject cart0;
    public GameObject cart1;
    public GameObject cart2;
    public GameObject cart3;
    public GameObject cart4;
    public GameObject cart5;
    public GameObject cart6;
    public GameObject cart7;
    public GameObject cart8;
    public GameObject cart9;
    public GameObject cart10;

    [Header("waypoint")]
    public GameObject waypoint;


    //public TMP_Text digitalTwinFeedbackTMP;
    //public TMP_Text uiFeedbackTMP;
    public string dataFromOPCUANode;


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
        //uiFeedbackTMP.text = "Factory machine " + factoryMachineID + " just registered " + nodeBeingMonitored + " as " + dataFromOPCUANode;

        if (dataFromOPCUANode == "0")
        {
            Debug.Log("cart 0 at machine"+ factoryMachineID);
            cart0.transform.position = waypoint.transform.position;
        }

        if (dataFromOPCUANode == "1")
        {
            Debug.Log("cart 1 at machine"+factoryMachineID);
            cart1.transform.position = waypoint.transform.position;
        }

        if (dataFromOPCUANode == "2")
        {
            Debug.Log("cart 2 at machine" + factoryMachineID);
            cart2.transform.position = waypoint.transform.position;
        }

        if (dataFromOPCUANode == "3")
        {
            Debug.Log("cart 3 at machine" + factoryMachineID);
            cart3.transform.position = waypoint.transform.position;
        }

        if (dataFromOPCUANode == "4")
        {
            Debug.Log("cart 4 at machine" + factoryMachineID);
            cart4.transform.position = waypoint.transform.position;
        }

        if (dataFromOPCUANode == "5")
        {
            Debug.Log("cart 5 at machine" + factoryMachineID);
            cart5.transform.position = waypoint.transform.position;
        }

        if (dataFromOPCUANode == "6")
        {
            Debug.Log("cart 6 at machine" + factoryMachineID);
            cart6.transform.position = waypoint.transform.position;
        }

        if (dataFromOPCUANode == "7")
        {
            Debug.Log("cart 7 at machine" + factoryMachineID);
            cart7.transform.position = waypoint.transform.position;
        }

        if (dataFromOPCUANode == "8")
        {
            Debug.Log("cart 8 at machine" + factoryMachineID);
            cart8.transform.position = waypoint.transform.position;
        }

        if (dataFromOPCUANode == "9")
        {
            Debug.Log("cart 9 at machine" + factoryMachineID);
            cart9.transform.position = waypoint.transform.position;
        }

        if (dataFromOPCUANode == "10")
        {
            Debug.Log("cart 10 at machine" + factoryMachineID);
            cart10.transform.position = waypoint.transform.position;
        }
    }

}
