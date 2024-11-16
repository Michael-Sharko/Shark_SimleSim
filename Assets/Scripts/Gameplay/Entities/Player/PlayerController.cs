using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Shark.Gameplay.Entities.Player
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private PlayerInput _input;

        public void OnMove(InputValue value)
        {
            Vector2 direction = value.Get<Vector2>();
            this.Move(direction);
        }
    }
}