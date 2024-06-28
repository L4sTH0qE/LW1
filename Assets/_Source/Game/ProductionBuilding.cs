using System;
using System.Collections;
using _Source.Core;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

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
    
    public void OnUpgradeLVL()
    {
      _gameManager.ResourceBank.ChangeResource((Core.GameResource)(5 + (transform.position.x + 4)/2), 1);
      _productionTime.CooldownTime = _productionTime.ProdTime * Math.Max(0,
        (1 - _gameManager.ResourceBank.GetResource((Core.GameResource)(5 + (transform.position.x + 4) / 2)).Value *
          1.0f / 100));
    }
  }
}