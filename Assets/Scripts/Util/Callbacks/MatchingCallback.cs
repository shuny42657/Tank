using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Util
{
    public class MatchingCallback : MonoBehaviour
    {
        public UnityEvent OnRoomJoined = new();
        public UnityEvent OnMatchingSuccessful = new();
    }
}
