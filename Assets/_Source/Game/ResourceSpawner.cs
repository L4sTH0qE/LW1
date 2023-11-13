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
            for (int i = 0; i < 5; ++i)
            {
                CreateResource(Core.GameResource.Humans + i);
            }
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