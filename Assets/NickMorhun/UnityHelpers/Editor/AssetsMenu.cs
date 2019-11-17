using UnityEditor;

namespace UnityHelpers.Editor
{
    internal static class AssetsMenu
    {
        [MenuItem("Unity Helpers/Assets/Upgrade All Assets")]
        private static void Upgrade()
        {
#if UNITY_2017_3_OR_NEWER
            AssetDatabase.ForceReserializeAssets();
#else
            var paths = AssetDatabase.GetAllAssetPaths();

            foreach (var assetPath in paths)
            {
                var mainAsset = AssetDatabase.LoadMainAssetAtPath(assetPath);
                EditorUtility.SetDirty(mainAsset);
            }

            AssetDatabase.SaveAssets();
#endif
        }
    }
}
