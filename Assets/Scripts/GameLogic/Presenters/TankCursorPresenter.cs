using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameLogic.Graphic;
using GameLogic.Bullet;

namespace Util
{
    public class TankCursorPresenter : MonoBehaviour
    {
        [SerializeField] SerializeInterface<ITriggerCallback<Vector3>> callBack;
        [SerializeField] SerializeInterface<ITrajectoryView> trajectoryView;
        [SerializeField] SerializeInterface<IShooter> shooter;

        private void Awake()
        {
            callBack.Value.OnFire.AddListener((pos) => trajectoryView.Value.ShowTrajectory(pos));
            callBack.Value.OnFire.AddListener((pos) => shooter.Value.SetDirection(pos));
        }
    }
}
