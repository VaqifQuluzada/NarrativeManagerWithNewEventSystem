//using GTVariable;
using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Video;
using VaqifQuluzada.Scripts.Data.Objectives;

namespace VaqifQuluzada.Scripts.Data.States
{
  [CreateAssetMenu(fileName ="NewStateData",menuName ="ScriptableObjects/StateData")]

  public class StateSO : ScriptableObject
  {
    [Header("Properties")]
    [SerializeField] private string stateName;

    [AllowNesting]
    [Expandable]
    [SerializeField] private StateObjectiveSO initializedObjectiveData;

    public StateObjectiveSO InitializedObjectiveData { get => initializedObjectiveData; set => initializedObjectiveData = value; }

    [Header("Links")]
    [AllowNesting]
    [Expandable]
    [SerializeField] private List<StateObjectiveSO> stateObjectives = new List<StateObjectiveSO>();
    public List<StateObjectiveSO> StateObjectives { get => stateObjectives; }


    //[SerializeField] private List<GameEvent> onStateBeginEvents;
    //[SerializeField] private List<GameEvent> onStateEndEvents;

    public virtual void InitializeState()
    {
      //foreach(GameEvent stateBeginEvent in  onStateBeginEvents) 
      //{
      //  stateBeginEvent.Raise();
      //}
    }

    public virtual void FinishState()
    {
      //foreach (GameEvent stateEndEvent in onStateEndEvents)
      //{
      //  stateEndEvent.Raise();
      //}
    }
  }
}
