using UnityEngine;

namespace _Source.Game
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] 
        private ResourceSpawner _resourceSpawner;
        
        private Core.ResourceBank _resourceBank;
        private void Awake()
        {
            _resourceBank = new Core.ResourceBank();
            _resourceBank.ChangeResource(Core.GameResource.Humans, 10);
            _resourceBank.ChangeResource(Core.GameResource.Food, 5);
            _resourceBank.ChangeResource(Core.GameResource.Wood, 5);
            _resourceSpawner.Init(_resourceBank);
        }
    }
}
