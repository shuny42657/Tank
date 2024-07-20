using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Util;
using GameLogic.Factory;

public class P_SimpleMatching_MatchingCallback : MonoBehaviour
{
    [SerializeField] MatchingCallback matchingCallback;
    [SerializeField] SerializeInterface<ITannkFactory> tankFactory;

    private void Awake()
    {
        matchingCallback.OnRoomJoined.AddListener(() => tankFactory.Value.GenerateTank(new Vector3(0f,0.5f,0f)));
    }
}
