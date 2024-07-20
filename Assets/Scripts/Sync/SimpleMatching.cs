using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;
using Photon.Pun;
using Util;

namespace Sync
{
    public class SimpleMatching : MonoBehaviourPunCallbacks
    {
        [SerializeField] MatchingCallback matchingCallback;
        // Start is called before the first frame update
        void Start()
        {
            PhotonNetwork.ConnectUsingSettings();
        }

        public override void OnConnectedToMaster()
        {
            var roomOpt = new RoomOptions();
            roomOpt.MaxPlayers = 2;
            PhotonNetwork.JoinOrCreateRoom("Room", roomOpt, TypedLobby.Default);
        }

        public override void OnJoinedRoom()
        {
            matchingCallback.OnRoomJoined.Invoke();
        }
    }
}
