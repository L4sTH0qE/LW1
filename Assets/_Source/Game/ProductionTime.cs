using UnityEngine;
using UnityEngine.UI;
using System.Collections;
namespace _Source.Game
{
  public class ProductionTime : MonoBehaviour
  {
    [SerializeField]
    private Button _button;
    
    [SerializeField]
    private Slider _slider;
    
    public float CooldownTime { get; set; }
    
    public float ProdTime { get; set; }
    
    public bool CanDoAction{ get; set; }
    public void StartTimer() => StartCoroutine(Cooldown());
    private void Start()
    {
      ProdTime = 5;
      _slider.enabled = false;
      CanDoAction = true;
      CooldownTime = ProdTime;
    }
    private IEnumerator Cooldown()
    {
      _button.enabled = false;
      CanDoAction = false;
      for (float invincibleTimeLeft = CooldownTime; invincibleTimeLeft > 0; invincibleTimeLeft -= Time.deltaTime)
      {
        yield return null;
        _slider.value = (CooldownTime - invincibleTimeLeft)/CooldownTime;
      }
      _slider.value = 0;
      CanDoAction = true;
      _button.enabled = true;
    }
  }
}