using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameLogic.Bullet
{
    public class BulletManager : MonoBehaviour
    {
        IReflectable reflectable;
        IDamageable damageable;
        IFlyable flyable;

        public void Init(IReflectable reflectable, IDamageable damageable, IFlyable flyable,BulletParamter parameter)
        {
            this.reflectable = reflectable;
            this.damageable = damageable;
            this.flyable = flyable;
            this.damageable.Damage = parameter.Damage;
            this.flyable.Velocity = parameter.Diection * parameter.Speed;
        }

    }
}
