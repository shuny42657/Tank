using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameLogic.Bullet
{
    public class LinearBulletFly : MonoBehaviour,IFlyable
    {
        Rigidbody rigid;
        public Vector3 Velocity { get; set; }
        [SerializeField] int reflectionCount;
        int reflected;
        public void Fly()
        {
            //Debug.Log($"vel : {Velocity * Time.deltaTime}");
            //transform.Translate(Velocity * Time.deltaTime);
        }

        private void Update()
        {
            Fly();
        }

        public void Shoot()
        {
            rigid = GetComponent<Rigidbody>();
            rigid.velocity = Velocity;
        }
    }
}

