using UnityEngine;

namespace _Source.Game
{
    public class ResourceSpawner : MonoBehaviour
    {
        [SerializeField] private GameObject _resourcePrefab;

        private Core.ResourceBank _resourceBank;

        public void Init(Core.ResourceBank resourceBank)
        {
            _resourceBank = resourceBank;
            CreateResource(Core.GameResource.Humans);
            CreateResource(Core.GameResource.Food);
            CreateResource(Core.GameResource.Wood);
            CreateResource(Core.GameResource.Stone);
            CreateResource(Core.GameResource.Gold);
        }

        private void CreateResource(Core.GameResource gameResource)
        {
            GameObject resourceObject = Instantiate(_resourcePrefab);
            if (resourceObject.TryGetComponent(out ResourceVisual visual))
            {
                visual.Init(gameResource, _resourceBank);
            }
        }
    }
}