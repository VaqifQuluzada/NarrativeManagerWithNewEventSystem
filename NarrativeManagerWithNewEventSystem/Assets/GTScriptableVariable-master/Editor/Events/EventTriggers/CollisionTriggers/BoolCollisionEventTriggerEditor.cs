using UnityEngine;
using UnityEditor;



namespace GTVariable.Editor
{
    [CustomEditor(typeof(BoolCollisionEventTrigger))]
    public class BoolCollisionEventTriggerEditor : CollisionEventTriggerEditor<BoolGameEvent, BoolEvent, bool>
    {

    }
}