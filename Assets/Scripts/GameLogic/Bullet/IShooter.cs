using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameLogic.Bullet
{
    public interface IShooter
    {
        public void Shoot(Vector3 targetPos);
        public void SetDirection(Vector3 targetPosition);
        public BulletType BulletType { get; set; }
        public BulletParamter Paramter { get; set; }
    }
}
