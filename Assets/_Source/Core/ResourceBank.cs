using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _Source.Core
{
    public class ResourceBank
    {
        private Dictionary<GameResource, ObservableInt> _resourceBank = new Dictionary<GameResource, ObservableInt>();

        public ResourceBank()
        {
            for (int i = 0; i < 10; ++i)
            {
                _resourceBank.Add(GameResource.Humans+i, new ObservableInt(0));
            }
        }
        
        // Увеличивает значение ресурса r из словаря на v.
        public void ChangeResource(GameResource r, int v)
        {
            _resourceBank[r].Value += v;
        }
        
        // Возвращает ObservableInt из словаря, соответствующий ресурсу r.
        public ObservableInt GetResource(GameResource r)
        {
            return _resourceBank[r];
        }
    }
}
