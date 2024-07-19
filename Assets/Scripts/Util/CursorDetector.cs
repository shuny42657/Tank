using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Util
{
    public class CursorDetector : MonoBehaviour,ICursorDetect,ITriggerCallback<Vector3>
    {
        public bool isActive;
        [SerializeField] Camera referenceCamera;

        public UnityEvent<Vector3> OnFire { get { return onFire; } }

        UnityEvent<Vector3> onFire = new();

        public void DetectCursor()
        {
            var ray = referenceCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray,out hit, Mathf.Infinity))
            {
                onFire.Invoke(hit.point);
                Debug.Log($"{hit.point}");
            }
        }

        // Update is called once per frame
        void Update()
        {
            if (isActive)
            {
                DetectCursor();
            }
        }
    }
}

