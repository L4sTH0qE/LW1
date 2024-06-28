using TMPro;
using UnityEngine;

namespace _Source.Game
{
    public class ResourceVisual : MonoBehaviour
    {
        [SerializeField] 
        private TextMeshProUGUI _valueText;
        
        private Core.GameResource _gameResource;
        
        public void Init(Core.GameResource gameResource, Core.ResourceBank resourceBank)
        {
            _gameResource = gameResource;
            resourceBank.GetResource(_gameResource).OnChanged += UpdateValue;
            if ((int)_gameResource < 5)
            {
                transform.position = new Vector3(-4 + 2 * (int)_gameResource, -0.6f);
            }
            else
            {
                transform.position = new Vector3(-14 + 2 * (int)_gameResource, 0.6f);
            }
            UpdateValue(resourceBank.GetResource(_gameResource).Value);
        }

        private void UpdateValue(object obj)
        {
            _valueText.text = $"{obj}";
        }
    }
}