using Shark.Gameplay.Common;
using UnityEngine;

namespace Shark.Gameplay.Enviroment.Subjects
{
    public class TreeObjectSubject : MonoBehaviour, ICollectable
    {
        private void OnEnable() => enabled = false;

        public void Collect()
        {
            Debug.Log("This is TREE!");
        }
    }
}