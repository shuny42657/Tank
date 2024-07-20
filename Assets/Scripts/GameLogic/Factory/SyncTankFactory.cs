using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Util;
using GameLogic.Tank;

namespace GameLogic.Factory
{
    public class SyncTankFactory : MonoBehaviour,ITannkFactory
    { 
        public ITank GenerateTank(Vector3 position)
        {
            var obj = PhotonNetwork.Instantiate("SphereTank",position,Quaternion.identity);
            var tank = obj.GetComponent<SyncTank>();
            tank.Init();
            return tank;
            
        }
    }
}

