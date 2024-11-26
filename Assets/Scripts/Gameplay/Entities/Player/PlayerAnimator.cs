using System;
using UnityEngine;
using UnityEngine.Events;

namespace Shark.Gameplay.Entities.Player
{
    public static class PlayerAnimatorParameterHash
    {
        public static readonly int Interact = Animator.StringToHash("Interact");
        public static readonly int Talk = Animator.StringToHash("Talk");
        public static readonly int Use = Animator.StringToHash("Use");
        public static readonly int Move = Animator.StringToHash("Move");

        public static readonly int SwingPickaxe = Animator.StringToHash("Swing.Pickaxe");
    }

    public static class PlayerAnimator
    {
        [System.Serializable]
        public enum PlayerAnimations
        {
            None,
            SwingPickaxe,
            SwingAxe,
            SwingShovel
        }
        private static Animator _animator;
        
        public static void RefreshAnimator(this PlayerController player, Vector2 direction)
        {
            if (_animator == null)
            {
                _animator = player.GetComponent<Animator>();
            }
        }

        public static void PlayAnimation(this PlayerController player, string animationName)
        {
            if (Enum.TryParse(animationName, false, out PlayerAnimations animation))
            {                
                switch (animation)
                {
                case PlayerAnimations.SwingPickaxe:
                    _animator.Play(PlayerAnimatorParameterHash.SwingPickaxe); 
                    break;
                }
            }
        }
    }
}