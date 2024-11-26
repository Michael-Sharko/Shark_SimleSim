using Shark.Gameplay.Common;
using UnityEngine;

namespace Shark.Gameplay.Enviroment.Subjects
{
    public abstract class WorldObjectSubject : MonoBehaviour, ICollectable
    {
        private GameObject _child;

        private void OnEnable() => enabled = false;

        public abstract void Collect();

        public void Refresh(GameObject child)
        {
            _child = child;
        }
    }
}