using JetBrains.Annotations;
using System.Collections.Generic;
using UnityEngine;

namespace UnityHelpers.Runtime
{
    public static class GameObjectNameExtensions
    {
        public static string GetFullName([CanBeNull] this GameObject gameObject)
        {
            if (gameObject == null)
            {
                return "*Invalid*";
            }

            var path = new Stack<string>();
            path.Push(gameObject.name);

            while (gameObject.transform.parent)
            {
                gameObject = gameObject.transform.parent.gameObject;
                path.Push(gameObject.name);
            }

            return string.Join("/", path);
        }
    }
}