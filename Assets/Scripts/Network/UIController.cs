﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public GameObject uiParent;
    private CustomNetworkManager networkManager;
    //private CustomNetworkDiscovery networkDiscovery;
    // Start is called before the first frame update
    void Start()
    {
     //   networkDiscovery = CustomNetworkDiscovery.Instance;
        networkManager = CustomNetworkManager.Instance;
    }
    public void ConfigAddress()
    {
        //Text text = GameObject.Find("AddressText").GetComponent<Text>();
        //networkManager.networkAddress = text.text;
    }
    public void StartHost()
    {
        ConfigAddress();
        //networkManager.StartServer();
        networkManager.StartHost();
        DisableButton();

    }
    public void StartClient()
    {
        ConfigAddress();
        Debug.Log("he?");
        networkManager.StartClient();
        DisableButton();
    }
    void DisableButton()
    {
        uiParent.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
