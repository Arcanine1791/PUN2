using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class Spawner : MonoBehaviour
{
    public GameObject playerPrefab;
    
    public List<Transform> spawnpoints;
    void Start()
    {
        Transform randomPos=spawnpoints[ Random.Range(0,spawnpoints.Count)];
        PhotonNetwork.Instantiate(playerPrefab.name,randomPos.position,Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
