using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Util
{
    public interface ITriggerCallback<T>
    {
        public UnityEvent<T> OnFire { get; }
    }
}
