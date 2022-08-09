using System;
using UnityEngine;

namespace Code_recommendations_HW_1
{
    [RequireComponent(typeof(Animator))]
    public class ThiefWalkForCracking : MonoBehaviour
    {
        [SerializeField] private float walkSpeed;
        [SerializeField] private Transform whatToCrack;

        private Animator _animator;
        private bool _doesCrackingAnimationStart = false;
        private static readonly int AnimationHashStartCracking = Animator.StringToHash("Start cracking");
        private const float Tolerance = 0.1f;

        private void Start()
        {
            _animator = GetComponent<Animator>();
        }

        private void Update()
        {
            if (Math.Abs(transform.position.x - whatToCrack.position.x) > Tolerance)
            {
                transform.position = new Vector3(transform.position.x + walkSpeed * Time.deltaTime,
                    transform.position.y,
                    transform.position.z);
            }
            else if (!_doesCrackingAnimationStart)
            {
                _animator.SetTrigger(AnimationHashStartCracking);
                _doesCrackingAnimationStart = true;
            }
        }
    }
}