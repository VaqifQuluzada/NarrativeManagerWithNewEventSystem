using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Video;

namespace VaqifQuluzada.Scripts.Data.Objectives
{
  [CreateAssetMenu(fileName = "NewStateObjectiveData", menuName = "ScriptableObjects/StateObjectiveData")]

  public class StateObjectiveSO : ScriptableObject
  {
    [SerializeField] private string stateObjectiveName;
    public string StateObjectiveName { get => stateObjectiveName; }

    [SerializeField] private bool stateObjectiveCompleteness;
    public bool StateObjectiveCompleteness
    {
      get => stateObjectiveCompleteness;
      set
      {
        if (value == true)
        {
          onStateObjectiveFinished.Invoke();
        }
        else
        {
          onStateObjectiveCancelled.Invoke();
        }

        stateObjectiveCompleteness = value;
      }
    }

    [SerializeField] private int stateObjectiveCompletenessDelay = 0;
    public int StateObjectiveCompletenessDelay { get => stateObjectiveCompletenessDelay; }

    [TextArea(2, 5)]
    [SerializeField] private string stateObjectiveDescription;
    public string StateObjectiveDescription { get => stateObjectiveDescription; }

    [SerializeField] private AudioClip stateObjectiveClip;
    public AudioClip StateObjectiveClip { get => stateObjectiveClip; }

    [SerializeField] private VideoClip stateObjectiveVideoClip;
    public VideoClip StateObjectiveVideoClip { get => stateObjectiveVideoClip; }


    [SerializeField] private UnityEvent onStateObjectiveFinished;
    [SerializeField] private UnityEvent onStateObjectiveCancelled;
  }
}

