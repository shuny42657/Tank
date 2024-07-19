using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Util
{
    public interface IKeyInputController
    {
        public UnityEvent<float> OnHAxis { get; }
        public UnityEvent<float> OnVAxis { get; }
    }
}
