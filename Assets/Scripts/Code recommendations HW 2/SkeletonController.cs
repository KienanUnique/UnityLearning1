using UnityEngine;

namespace Code_recommendations_HW_2
{
    [RequireComponent(typeof(SkeletonMoving))]
    public class SkeletonController : MonoBehaviour
    {
        [SerializeField] private float secondsBeforeDestroy = 3.0f;

        private SkeletonMoving _skeletonMoving;
        private SkeletonVisual _skeletonVisual;

        private void Start()
        {
            _skeletonMoving = GetComponent<SkeletonMoving>();
            _skeletonVisual = GetComponentInChildren<SkeletonVisual>();
            _skeletonMoving.StartMovingRight();
        }

        public void Die()
        {
            _skeletonVisual.PlayDieAnimation();
            _skeletonMoving.StopMovingRight();
            Invoke(nameof(Destroy), secondsBeforeDestroy);
        }

        private void Destroy()
        {
            Destroy(this.gameObject);
        }
    }
}