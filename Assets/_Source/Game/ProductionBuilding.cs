using System;
using _Source.Core;
using TMPro;
using UnityEngine;

namespace _Source.Game
{
  public class ProductionBuilding : MonoBehaviour
  {
    [SerializeField]
    private GameManager _gameManager;

    public void OnButtonClicked()
    {
      _gameManager.ResourceBank.ChangeResource((Core.GameResource)((transform.position.x + 4)/2), 1);
    }
  }
}