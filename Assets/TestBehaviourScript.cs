#if UNITY_2020_2_OR_NEWER
#nullable enable
using UnityEngine;
using UnityHelpers;

public class TestBehaviourScript : MonoBehaviour
{
    private void Start()
    {
        var tested = (string?)null;
        var noNull = tested.NotNull(nameof(tested));
        Debug.Log(noNull.Length);
    }
}

#endif