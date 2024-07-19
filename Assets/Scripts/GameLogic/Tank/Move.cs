using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameLogic.Tank
{
    public class Move : MonoBehaviour, IMovable
    {
        public void MoveHorizontal(float speed)
        {
            transform.Translate(Time.deltaTime * speed, 0f, 0f);
        }

        public void MoveVertical(float speed)
        {
            transform.Translate(0f, 0f, Time.deltaTime * speed);
        }
    }
}
