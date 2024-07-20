using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameLogic.Bullet
{
    public interface IDamageable
    {
        public float Damage { get; set; }
    }

    public class Damageable : IDamageable
    {
        public float Damage { get; set; }
    }
}
