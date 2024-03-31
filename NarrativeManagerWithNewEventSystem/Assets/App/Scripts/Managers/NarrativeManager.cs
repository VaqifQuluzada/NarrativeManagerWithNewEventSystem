using NaughtyAttributes;
using System;
using System.Collections.Generic;
using UnityEngine;
using VaqifQuluzada.Scripts.Data.States;

namespace VaqifQuluzada.Scripts.Managers
{
  public class NarrativeManager : MonoBehaviour
  {
    [Header("Properties")]
    [SerializeField] private bool beginOnStartup = false;

    [Header("Links")]
    [AllowNesting]
    [Expandable]
    [SerializeField] private List<StateSO> statesList = new List<StateSO>();

    [ReadOnly]
    [AllowNesting]
    [Expandable]
    [SerializeField] private StateSO currentState;

    /// <summary>
    /// For testing purpose you can change this value.
    /// </summary>
    [SerializeField] private int currentIndex = 0;

    #region Unity Methods

    void Start()
    {
      if (beginOnStartup)
      {
        InitializeNarrative();
      }
    }

    #endregion

    #region Custom Methods

    private void InitializeNarrative()
    {
      if (statesList.Count == 0)
      {
        Debug.LogError($"[InitializeNarrative] Narrative states list is empty");
        return;
      }

      InitializeState(currentIndex);
    }

    private void InitializeState(int stateIndex)
    {
      if (stateIndex >= statesList.Count)
      {
        Debug.LogError($"[InitializeNarrative] Narrative state index:{stateIndex} is higher than state list count:{statesList.Count}");
        return;
      }

      currentState = statesList[stateIndex];

      currentState.InitializeState();
    }

    private void InitializeObjective()
    {

    }

    #endregion
  }
}