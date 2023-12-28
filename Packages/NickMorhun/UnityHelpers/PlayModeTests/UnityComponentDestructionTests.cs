using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace UnityHelpers.PlayModeTests
{
    public class UnityComponentDestructionTests
    {
        private const float TestsTimeScale = 10f;

        private static readonly float[] delays = new float[] { 0f, .01f, 2f };

        [Test]
        public void DestroyObjectImmediate_DestroysGameObject()
        {
            var testObject = new GameObject("test object");

            testObject.transform.DestroyObjectImmediate();

            Assert.IsFalse(testObject);
        }

        [UnityTest]
        public IEnumerator DestroyObject_DestroysGameObject()
        {
            var testObject = new GameObject("test object");

            testObject.transform.DestroyObject();

            yield return null;

            Assert.IsFalse(testObject);
        }

        [UnityTest]
        public IEnumerator DestroyObject_WithDelay_DestroysGameObject([ValueSource(nameof(delays))] float delay)
        {
            float coroutineDelay = Mathf.Max(delay * 1.1f, .01f);
            Time.timeScale = TestsTimeScale;
            var testObject = new GameObject("test object");

            testObject.transform.DestroyObject(delay);

            yield return new WaitForSeconds(coroutineDelay);

            Time.timeScale = 1f;
            Assert.IsFalse(testObject);
        }
    }
}
