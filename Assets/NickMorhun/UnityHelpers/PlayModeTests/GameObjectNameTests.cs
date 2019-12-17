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
            var testObject = new GameObject("root object");
            var testObject1 = new GameObject(" ");
            var testObject2 = new GameObject("test object");

            testObject1.transform.parent = testObject.transform;
            testObject2.transform.parent = testObject1.transform;

            Assert.AreEqual("root object/ /test object", testObject2.GetFullName());
        }   
    }
}
