using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameLogic.Graphic
{
    public class TankBulletTrajectoryView : MonoBehaviour,ITrajectoryView
    {
        [SerializeField] LineRenderer renderer;
        Vector3[] ends = new Vector3[2];

        public void ShowTrajectory(Vector3 endPoint)
        {
            ends[0] = transform.position;
            ends[1] = new Vector3(endPoint.x, transform.position.y, endPoint.z);
            renderer.SetPositions(ends);
        }
    }
}

