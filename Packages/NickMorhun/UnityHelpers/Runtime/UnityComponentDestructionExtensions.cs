using UnityEngine;

namespace UnityHelpers
{
    public static class UnityComponentDestructionExtensions
    {
        public static void DestroyObject(this Component unityComponent)
        {
            if (unityComponent != null)
            {
                Object.Destroy(unityComponent.gameObject);
            }
        }

        public static void DestroyObject(this Component unityComponent, float delay)
        {
            if (unityComponent != null)
            {
                Object.Destroy(unityComponent.gameObject, delay);
            }
        }

        public static void DestroyObjectImmediate(this Component unityComponent)
        {
            if (unityComponent != null)
            {
                Object.DestroyImmediate(unityComponent.gameObject);
            }
        }
    }
}