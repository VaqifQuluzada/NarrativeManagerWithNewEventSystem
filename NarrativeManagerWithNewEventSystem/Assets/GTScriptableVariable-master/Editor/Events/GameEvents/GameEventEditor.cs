using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


namespace GTVariable.Editor
{

    [CustomEditor(typeof(EmptyGameEvent))]
    public class GameEventEditor : GameEventEditorBase<EmptyGameEvent>
    {
        public override void RaiseEvent()
        {
            gameEvent.Raise();
        }
    }
}