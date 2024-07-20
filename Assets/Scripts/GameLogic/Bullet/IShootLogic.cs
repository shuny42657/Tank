using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameLogic.Factory;

namespace GameLogic.Bullet
{
    public interface IShootLogic
    {
        public void Shoot(BulletType bulletType,Vector3 startPosition,BulletParamter prameter, int quantity);
        public void SetMotherFactory(IBulletMotherFactory motherFactory);
    }
}
