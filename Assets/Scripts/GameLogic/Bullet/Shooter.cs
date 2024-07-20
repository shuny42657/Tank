using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Util;
using Photon.Realtime;
using Photon.Pun;

namespace GameLogic.Bullet
{
    public class Shooter : MonoBehaviourPunCallbacks, IShooter
    {
        public BulletType BulletType { get; set; }
        public BulletParamter Paramter { get; set; }
        IShootLogic ShootLogic {get;set;}

        public void SetDirection(Vector3 targetPosition)
        {
            if (Paramter == null)
            {
                Paramter = new();
                Paramter.Speed = 5f;
            }
            var dirVel = targetPosition - transform.position;
            Paramter.Diection = dirVel.normalized;
        }
        public void Shoot(Vector3 targetPos)
        {
            Debug.Log($"Bullet Parameter : {Paramter.Speed}, {Paramter.Diection}");
            ShootLogic.Shoot(BulletType, transform.position, Paramter, 1);
        }
        private void Start()
        {
            ShootLogic = GetComponent<IShootLogic>();
        }
        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Shoot(Vector3.zero);
            }
        }
    }
}
