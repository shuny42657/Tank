using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameLogic.Graphic;

namespace Util
{
    public class TankCursorPresenter : MonoBehaviour
    {
        [SerializeField] SerializeInterface<ITriggerCallback<Vector3>> callBack;
        [SerializeField] SerializeInterface<ITrajectoryView> trajectoryView;

        private void Awake()
        {
            callBack.Value.OnFire.AddListener((pos) => trajectoryView.Value.ShowTrajectory(pos));
        }
    }
}
