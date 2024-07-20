using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameLogic.Factory;

namespace GameLogic.Bullet
{
    public class SingleBulletShootLogic : MonoBehaviour,IShootLogic
    {
        [SerializeField] IBulletMotherFactory motherBulletFactory;

        public void SetMotherFactory(IBulletMotherFactory motherFactory)
        {
            motherBulletFactory = motherFactory;
        }

        public void Shoot(BulletType bulletType, Vector3 startPosition, BulletParamter prameter, int quantity)
        {
            var bullet = motherBulletFactory.GenerateBullete(bulletType, startPosition, prameter);
            bullet.GetComponent<IFlyable>().Shoot();
        }

        private void Start()
        {
            motherBulletFactory = GameObject.Find("MotherBulletFactory").GetComponent<IBulletMotherFactory>();
        }
    }
}
