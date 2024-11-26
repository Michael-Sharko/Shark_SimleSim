using Shark.Gameplay.Common;
using UnityEngine;

namespace Shark.Gameplay.Enviroment.Subjects
{
    public class StoneObjectSubject : MonoBehaviour, ICollectable
    {
        private void OnEnable() => enabled = false;

        public void Collect()
        {
            Debug.Log("This is ROCK!");
        }
    }
}