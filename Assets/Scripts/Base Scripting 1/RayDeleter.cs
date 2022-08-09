using UnityEngine;

namespace Base_Scripting_1
{
    public class RayDeleter : MonoBehaviour
    {
        [SerializeField] private ContactFilter2D filter;
        private readonly RaycastHit2D[] _results = new RaycastHit2D[1];

        private void Update()
        {
            var thisTransform = transform;
            var right = thisTransform.right;
            var position = thisTransform.position;

            var collisionCount = Physics2D.Raycast(position, right, filter, _results);
            Debug.DrawRay(position, right * 10, Color.red);
            if (collisionCount != 0)
            {
                foreach (var hit in _results)
                {
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }
}