using UnityEngine;

namespace Shark.Gameplay.Entities.Player
{
    public static class PlayerMovement
    {
        private static CharacterController _controller;
        public static void Move(this PlayerController player, Vector2 direction)
        {
            if (_controller == null)
            {
                _controller = player.GetComponent<CharacterController>();
            }
            _controller.Move(direction);
        }
    }
}