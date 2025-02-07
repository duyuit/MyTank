﻿using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class CustomNetworkManager : NetworkManager
{
    [SerializeField]
    public GameObject camera;
    private static CustomNetworkManager instace;
    public static CustomNetworkManager Instance
    {
       get
       {
            if (instace == null)
                instace = FindObjectOfType<CustomNetworkManager>();
            return instace;
       }
    }
    public override void OnServerAddPlayer(NetworkConnection conn, short playerControllerId)
    {
        SetUpNewPlayer(conn, playerControllerId);
       // SetUpNPC(conn, playerControllerId);
    }
    public override void OnClientConnect(NetworkConnection conn)
    {
        base.OnClientConnect(conn);
    }
    void SetUpNPC(NetworkConnection conn, short id)
    {
     
    }
    void SetUpNewPlayer(NetworkConnection conn, short id)
    {
        GameObject player = Instantiate(playerPrefab);
        player.transform.position =new Vector3(Random.Range(1,40), player.transform.position.y, Random.Range(1, 40));
        NetworkServer.AddPlayerForConnection(conn, player, id);
        
        //GameObject npc = Instantiate(spawnPrefabs[0]);
        //npc.transform.position = new Vector3(npc.transform.position.x + conn.connectionId * 2, npc.transform.position.y + 1, npc.transform.position.z);
        //NetworkServer.Spawn(npc);
    
    }
    public string GenerateNetworkBroadcastData()
    {
        return "ConnectionBroadcastMessage:" + networkPort;
    }

}
