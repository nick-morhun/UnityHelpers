using UnityEditor;
using UnityEngine;
using UnityHelpers.Runtime;

namespace UnityHelpers.Editor
{
    internal static class SelectionMenu
    {
        [MenuItem("Unity Helpers/Selection/Print Global Position")]
        public static void PrintGlobalPosition()
        {
            if (PrintGlobalPositionValidate())
            {
                var activeGameObject = Selection.activeGameObject;
                Debug.Log($"{activeGameObject.GetFullName()} is at {activeGameObject.transform.position}");
            }
        }

        [MenuItem("Unity Helpers/Selection/Print Global Position", true)]
        public static bool PrintGlobalPositionValidate()
        {
            return Selection.activeGameObject && Selection.activeGameObject.scene.isLoaded;
        }

        [MenuItem("Unity Helpers/Selection/Print Asset Path")]
        public static void PrintAssetPath()
        {
            var activeObject = Selection.activeObject;

            if (activeObject != null)
            {
                var path = AssetDatabase.GetAssetPath(activeObject);
                Debug.Log(string.IsNullOrEmpty(path) ? "The object is not in the asset." : path);
            }
        }

        [MenuItem("Unity Helpers/Selection/Print Asset Path", true)]
        public static bool PrintAssetPathValidate()
        {
            return Selection.activeObject;
        }

        [MenuItem("Unity Helpers/Selection/Ping Inspected Object %#I")]
        public static void PingInspectedObject()
        {
            EditorGUIUtility.PingObject(Selection.activeObject);
        }

        [MenuItem("Unity Helpers/Selection/Ping Inspected Object %#I", true)]
        public static bool SelectInspectedObjectValidate()
        {
            return Selection.activeObject;
        }
    }
}