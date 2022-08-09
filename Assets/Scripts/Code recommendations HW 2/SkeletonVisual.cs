using UnityEngine;

namespace Code_recommendations_HW_2
{
    [RequireComponent(typeof(Animator))]
    public class SkeletonVisual : MonoBehaviour
    {
        private Animator _animator;
        private static readonly int AnimationHashDie = Animator.StringToHash("Die");

        private void Start()
        {
            _animator = GetComponent<Animator>();
        }

        public void PlayDieAnimation()
        {
            _animator.SetTrigger(AnimationHashDie);
        }
    }
}