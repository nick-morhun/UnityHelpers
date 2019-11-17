using UnityEditor;
using UnityEngine;

namespace UnityHelpers.Editor
{
    internal static class OtherMenu
    {
        [MenuItem("Unity Helpers/Other/Open Persistent Data Path")]
        public static void OpenPersistentDataPath()
        {
            EditorUtility.RevealInFinder(Application.persistentDataPath);
        }
    }
}