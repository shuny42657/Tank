using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameLogic.Bullet
{
    public interface IFlyable
    {
        public Vector3 Velocity { get; set; }
        void Fly();
        void Shoot();
    }
}
