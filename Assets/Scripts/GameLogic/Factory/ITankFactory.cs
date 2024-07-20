using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameLogic.Tank;

namespace GameLogic.Factory
{
    public interface ITannkFactory
    {
        public ITank GenerateTank(Vector3 position);
    }
}
