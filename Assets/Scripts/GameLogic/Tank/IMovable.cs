using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameLogic.Tank
{
    public interface IMovable
    {
        public void MoveHorizontal(float speed);
        public void MoveVertical(float speed);
    }
}
