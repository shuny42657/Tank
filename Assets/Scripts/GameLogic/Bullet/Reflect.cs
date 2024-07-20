using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameLogic.Bullet
{
    public class Reflect : MonoBehaviour, IReflectable
    {
        [SerializeField] int reflectCount;
        int reflected;
        public void OnReflect()
        {
            reflected++;
            if(reflected == reflectCount)
            {
                Destroy(gameObject);
            }
        }

        private void OnCollisionEnter(Collision collision)
        {
            OnReflect();
        }
    }
}
