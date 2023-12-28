using NUnit.Framework;
using UnityEngine;
using UnityHelpers.Runtime;

namespace Tests
{
    public class GameObjectNameTests
    {
        [Test]
        public void GetFullName_ReturnsHierarchyNames()
        {
            var rootObject = new GameObject("root object");

            var level1Object1 = new GameObject("level1 Object1");
            var level1Object2 = new GameObject("level1 Object2");
            var level1Object3 = new GameObject("level1 Object3");

            var level2Object1 = new GameObject("level2 Object1");
            var level2Object2 = new GameObject("level2 Object2");
            var level2Object3 = new GameObject("level2 Object3");

            level1Object1.transform.parent = rootObject.transform;
            level1Object2.transform.parent = rootObject.transform;
            level1Object3.transform.parent = rootObject.transform;

            level2Object1.transform.parent = level1Object1.transform;
            level2Object2.transform.parent = level1Object2.transform;
            level2Object3.transform.parent = level1Object2.transform;

            Assert.AreEqual("root object/level1 Object2/level2 Object3", level2Object3.GetFullName());
        }   
    }
}
