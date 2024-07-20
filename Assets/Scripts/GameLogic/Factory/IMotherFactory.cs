using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameLogic.Bullet;

namespace GameLogic.Factory
{
    public interface IMotherFactory<T, S> where T : System.Enum
    {
        public S Generate(T name);
    }

    public interface IBulletMotherFactory
    {
        public BulletManager GenerateBullete(BulletType bulletType, Vector3 pos, BulletParamter bulletParameter);
    }
}
