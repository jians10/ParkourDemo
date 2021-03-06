﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using System.IO;

public class PlayerManger : MonoBehaviour
{
    PhotonView PV;

    void Awake()
    {
        PV = GetComponent<PhotonView>();
    }


    // Start is called before the first frame update
    void Start()
    {
        if (PV.IsMine)
        {
            CreateController();
        }
    }

    void CreateController()
    {
        Debug.Log("Instantiate Player Controller");
        PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "PlayerControllerNeo"), Vector3.zero, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
