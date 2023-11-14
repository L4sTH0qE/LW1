using UnityEngine;
using System.Collections;
namespace _Source.Game
{
  public class ProductionTime : MonoBehaviour
  {
    public float CooldownTime { get; set; }
    public bool CanDoAction{ get; set; }
    public void StartTimer() => StartCoroutine(Cooldown());
    private void Start()
    {
      CanDoAction = true;
      CooldownTime = 3;
    }
    private IEnumerator Cooldown()
    {
      CanDoAction = false;
      yield return new WaitForSeconds(CooldownTime);
      CanDoAction = true;
    }
  }
}