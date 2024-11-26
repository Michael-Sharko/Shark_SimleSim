using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Shark.Gameplay.Entities.Player
{
    [CustomEditor(typeof(PlayerController))]
    public class PlayerControllerEditor : Editor
    {
        PlayerController _player;
        Editor _editor;

        private void OnEnable() => _player = (PlayerController)target;
        
        public override void OnInspectorGUI()
        {
            UpdateEditorScope();
            DrawSettingsEditor(_player.model, ref _player.model.foldout, ref _editor);
        }

        private void UpdateEditorScope()
        {
            base.OnInspectorGUI();
        }

        private void DrawSettingsEditor(Object settings, ref bool foldout, ref Editor editor)
        {
            if (settings != null && 
                (foldout = EditorGUILayout.InspectorTitlebar(foldout, settings)))
            {
                CreateCachedEditor(settings, null, ref editor);
                editor.OnInspectorGUI();                
            }
        }
    }
}