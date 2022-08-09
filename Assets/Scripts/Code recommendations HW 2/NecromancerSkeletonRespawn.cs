using UnityEngine;

namespace Code_recommendations_HW_2
{
    public class NecromancerSkeletonRespawn : MonoBehaviour
    {
        [SerializeField] private GameObject skeletonPrefab;

        private Vector3 _spawnPoint;

        private void Start()
        {
            _spawnPoint = transform.GetChild(0).position;
        }

        public void Spawn()
        {
            Instantiate(skeletonPrefab, _spawnPoint, Quaternion.identity);
        }
    }
}