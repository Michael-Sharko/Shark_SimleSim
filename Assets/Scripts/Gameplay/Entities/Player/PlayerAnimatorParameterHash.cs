using UnityEngine;

namespace Shark.Gameplay.Entities.Player
{
    public static class PlayerAnimatorParameterHash
    {
        public static readonly int Interact = Animator.StringToHash("Interact");
        public static readonly int Talk = Animator.StringToHash("Talk");
        public static readonly int Use = Animator.StringToHash("Use");
        public static readonly int Move = Animator.StringToHash("Move");
    }
}