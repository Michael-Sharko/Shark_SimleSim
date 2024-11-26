
using UnityEngine;

namespace Shark.Gameplay.Common
{
    public interface ICollectable
    {
        void Refresh(GameObject child);
        void Collect();
    }
}