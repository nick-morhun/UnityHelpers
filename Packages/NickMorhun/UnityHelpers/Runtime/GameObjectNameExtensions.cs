using JetBrains.Annotations;
using System.Collections.Generic;
using UnityEngine;

namespace UnityHelpers
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

#if NET_4_6
            return string.Join("/", path);
#else
            return string.Join("/", path.ToArray());
#endif
        }
    }
}