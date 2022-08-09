using System.Collections;
using UnityEngine;

namespace Code_recommendations_HW_2
{
    public class SkeletonMoving : MonoBehaviour
    {
        [SerializeField] private float walkSpeed = 3.0f;

        private IEnumerator _walkRight;

        private void Start()
        {
            _walkRight = WalkRight();
        }

        private IEnumerator WalkRight()
        {
            while (true)
            {
                transform.position = new Vector3(transform.position.x + walkSpeed * Time.deltaTime,
                    transform.position.y,
                    transform.position.z);
                yield return null;
            }
        }

        public void StartMovingRight()
        {
            StartCoroutine(_walkRight);
        }

        public void StopMovingRight()
        {
            StopCoroutine(_walkRight);
        }
    }
}