using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Util;

namespace GameLogic.Tank
{
    public class SyncTank : MonoBehaviourPunCallbacks,ITank
    {
        [SerializeField] CursorDetector cursorDetector;
        [SerializeField] PlayerControllerPresenter playerControllerPresenter;

        public void Init()
        {
            photonView.RPC(nameof(SyncInit), RpcTarget.AllBuffered);
        }

        [PunRPC] public void SyncInit()
        {
            if (photonView.IsMine)
            {
                cursorDetector.isActive = true;
                cursorDetector.SetReferenceCamera(Camera.main);
                playerControllerPresenter.Set();
            }
            else
            {
                cursorDetector.isActive = false;
            }
        }
    }
}
