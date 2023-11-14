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
    [SerializeField]
    private ProductionTime _productionTime;
    public void OnButtonClicked()
    {
      if (!_productionTime.CanDoAction) return;
      _gameManager.ResourceBank.ChangeResource((Core.GameResource)((transform.position.x + 4)/2), 1);
      _productionTime.StartTimer();
    }
  }
}