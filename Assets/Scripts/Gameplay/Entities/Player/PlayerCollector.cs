using Shark.Gameplay.Common;
using Shark.Gameplay.Entities.Player;
using System.Collections.Generic;
using UnityEngine;

namespace Shark.Gameplay.Enviroment
{
    public static class PlayerCollector
    {
        private static Stack<ICollectable> _collectables = new();

        public static void RefreshCollector(this PlayerController player)
        {
            _collectables ??= new();
        }

        public static bool TryPushCollectableToCollector(this PlayerController player, Collider other)
        {
            var collectable = other.GetComponentInParent<ICollectable>();
            if (collectable != null)
            {
                _collectables.Push(collectable);
            }
            return collectable != null;
        }

        public static bool TryPopCollectableFromCollector(this PlayerController player, Collider other, out ICollectable collectable)
        {
            bool success = false;
            collectable = other.GetComponentInParent<ICollectable>();
            if (collectable != null)
            {
                if (success = _collectables.Count > 0)
                {
                    _collectables.Pop();
                }
            }
            return success;
        }

        public static bool TryInteractCollector(this PlayerController player)
        {
            bool success = false;
            if (success = _collectables.TryPeek(out var collectable))
            {
                collectable.Collect();
            }
            return success;
        }
    }
}