using System.Collections;
using System.Collections.Generic;
using GameLogic.Bullet;
using UnityEngine;
using Util;

namespace GameLogic.Factory
{
    public class MotherBulletFactory : MonoBehaviour,IBulletMotherFactory
    {
        [SerializeField] SerializeInterface<IBulletFactory> normalBulletFactory;
        public BulletManager GenerateBullete(BulletType bulletType, Vector3 pos, BulletParamter bulletParameter)
        {
            switch (bulletType)
            {
                case BulletType.Normal:
                    return normalBulletFactory.Value.GenerateBullet(pos, bulletParameter);
                default:
                    return null;

            }
        }
    }
}
