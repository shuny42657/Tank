using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameLogic.Bullet;

namespace GameLogic.Factory
{
    public interface IFactory<T>
    {
        public T Generate(Vector3 position);
    }

    public interface IBulletFactory
    {
        public BulletManager GenerateBullet(Vector3 position, BulletParamter paramter);
    }
}
