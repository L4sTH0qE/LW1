using TMPro;
using UnityEngine;

namespace _Source.Game
{
    public class ResourceVisual : MonoBehaviour
    {
        [SerializeField] 
        private TextMeshProUGUI _valueText;
        
        [SerializeField] 
        private SpriteRenderer _spriteRenderer;
        
        private Core.GameResource _gameResource;
        
        public void Init(Core.GameResource gameResource, Core.ResourceBank resourceBank)
        {
            _gameResource = gameResource;
            resourceBank.GetResource(_gameResource).OnChanged += UpdateValue;
            transform.position = new Vector3(-4 + 2 * (int)_gameResource, 0);
            UpdateValue(resourceBank.GetResource(_gameResource).Value);
        }

        private void UpdateValue(object obj)
        {
            _valueText.text = $"{obj}";
        }
    }
}