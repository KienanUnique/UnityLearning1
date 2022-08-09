using UnityEngine;

namespace Code_recommendations_HW_2
{
    [RequireComponent(typeof(BoxCollider2D))]
    public class SkeletonKillZone : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.gameObject.TryGetComponent(out SkeletonController skeleton))
            {
                skeleton.Die();
            }
        }
    }
}