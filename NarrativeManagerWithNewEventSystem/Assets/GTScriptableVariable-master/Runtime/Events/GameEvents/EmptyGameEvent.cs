

using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

namespace GTVariable
{

    /// <summary>
    /// Zero argument game event
    /// </summary>
    [CreateAssetMenu(menuName = "ScriptableVars/Events/Event")]
    public class EmptyGameEvent : GameEventBase
    {
        public void Raise()
        {
            if (isLogged)
            {
                UnityEngine.Debug.Log ("[GameEvent] Raised");
            }
            
            OnEventRaised?.Invoke();
        }

        public static EmptyGameEvent operator +(EmptyGameEvent gameEvent, UnityAction action)
        {
            gameEvent.OnEventRaised += action;
            return gameEvent;
        }

        public static EmptyGameEvent operator -(EmptyGameEvent gameEvent, UnityAction action)
        {
            gameEvent.OnEventRaised -= action;
            return gameEvent;
        }

    }
}