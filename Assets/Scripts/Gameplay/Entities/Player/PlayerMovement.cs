using UnityEngine;

namespace Shark.Gameplay.Entities.Player
{
    public static class PlayerMovement
    {
        private static CharacterController _controller;
        private static Vector3 _direction;

        public static void RefreshMovement(this PlayerController player, Vector2 direction)
        {
            if (_controller == null)
            {
                _controller = player.GetComponent<CharacterController>();
            }
            _direction = new(direction.x, .0f, direction.y);
        }

        public static void Move(this PlayerController player, float speed)
        {
            _controller.Move(speed * Time.fixedDeltaTime * _direction);
        }
    }
}