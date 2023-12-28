using UnityEngine;
using JetBrains.Annotations;
using UnityEngine.Scripting.APIUpdating;

namespace UnityHelpers
{
    [MovedFrom("UnityHelpers.Runtime")]
    public sealed class AnimationHash : StateMachineBehaviour
    {
        [UsedImplicitly]
        [SerializeField]
        private int Hash;

        public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            Hash = stateInfo.shortNameHash;
        }

        public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            Hash = stateInfo.shortNameHash;
        }
    }
}