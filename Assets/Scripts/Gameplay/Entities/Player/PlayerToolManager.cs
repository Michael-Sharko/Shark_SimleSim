using System.Collections.Generic;
using UnityEngine;

namespace Shark.Gameplay.Entities.Player
{
    public static class PlayerToolManager
    {
        public enum Tools
        {
            None,

            Axe,
            Pickaxe,
            Shovel,

            Count
        }

        private static Tools _activeTool = Tools.None;
        private static Dictionary<Tools, GameObject> _toolContainer;
        
        private static bool IsEmptyContainer => (_toolContainer == null || _toolContainer.Count <= 0);

        public static void RefreshToolContainer(this PlayerController player, PlayerToolContainer toolContainer)
        {
            _toolContainer ??= new();
            _toolContainer.Clear();

            var tools = toolContainer.tools;
            var gameObjects = toolContainer.gameObjects;

            int count = Mathf.Min(tools.Count, gameObjects.Count);
            for (int index = 0; index < count; ++index)
            {
                gameObjects[index].SetActive(tools[index] == _activeTool);
                _toolContainer.Add(tools[index], gameObjects[index]);
            }
        }

        public static void SelectTool(this PlayerController player, Tools tool)
        {
            if (IsEmptyContainer)
                return;

            if (tool >= Tools.Count) tool = Tools.None;

            _toolContainer[_activeTool].SetActive(false);
            _toolContainer[_activeTool = tool].SetActive(true);
        }

        public static void SelectNextTool(this PlayerController player)
        {
            if (IsEmptyContainer) 
                return;

            SelectTool(player, _activeTool + 1);
        }
    }
}