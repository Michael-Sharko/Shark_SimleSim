using Shark.Gameplay.Common;
using Shark.Gameplay.Enviroment;
using Shark.Gameplay.Enviroment.Subjects;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Shark.Gameplay.Entities.Player
{
    [Serializable]
    public struct PlayerObserverSubjects
    {
        public StoneObjectSubject stoneObjectSubject;
        public TreeObjectSubject treeObjectSubject;
    }

    [Serializable]
    public struct PlayerToolContainer
    {
        public List<PlayerToolManager.Tools> tools;
        public List<GameObject> gameObjects;
    }

    public class PlayerController : MonoBehaviour
    {
        [SerializeField] public PlayerModel model;

        [SerializeField] private PlayerInput _input;
        [SerializeField] private GameObject _hand;

        [SerializeField] private PlayerObserverSubjects _subjects;
        [SerializeField] private PlayerToolContainer _toolContainer;

        private void Start() => Initialize();
        private void OnValidate() => Initialize();

        private void Initialize()
        {
            this.RefreshMovement(Vector2.zero);
            this.RefreshToolContainer(_hand, _toolContainer);

            this.RefreshCollector();
        }

        private void FixedUpdate()
        {
            this.Move(model.speed);
        }

        public void OnMove(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                this.RefreshMovement(context.ReadValue<Vector2>());
            }
        }

        public void OnChoicedNextTool(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                this.SelectNextTool();
            }
        }

        public void OnInteracted(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                this.TryInteractCollector();
            }
        }

        public void OnTriggerEnter(Collider other)
        {
            if (this.TryPushCollectableToCollector(other))
                return;
        }

        public void OnTriggerExit(Collider other)
        {
            if (this.TryPopCollectableFromCollector(other, out var _))
                return;
        }
    }
}