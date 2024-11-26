using System;
using UnityEngine;

namespace Shark.Gameplay.Entities.Player
{
    [CreateAssetMenu(fileName = "NewPlayerModel", menuName = "Gameplay/Player/New Model")]
    public class PlayerModel : ScriptableObject
    {
        [HideInInspector, NonSerialized]
        public bool foldout = true;

        public float speed;
    }
}