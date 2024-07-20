using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameLogic.Bullet;

namespace GameLogic.Factory
{
    public class NormalBulletFactory : MonoBehaviour,IBulletFactory
    {
        [SerializeField] BulletManager normalBullete;

        public BulletManager GenerateBullet(Vector3 position, BulletParamter parameter)
        {
            var newBullet = Instantiate(normalBullete, position, Quaternion.identity);
            var reflect = newBullet.GetComponent<IReflectable>();
            var fly = newBullet.GetComponent<IFlyable>();
            var damageable = new Damageable();
            newBullet.Init(reflect, damageable, fly, parameter);
            return newBullet;
        }
    }
}
