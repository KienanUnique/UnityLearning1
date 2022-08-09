using System.Collections;
using UnityEngine;

namespace Code_recommendations_HW_2
{
    public class NecromancersController : MonoBehaviour
    {
        [SerializeField] private float spawnDelaySeconds = 2.0f;

        private NecromancerSkeletonRespawn[] _necromancers;

        private void Start()
        {
            _necromancers = GetComponentsInChildren<NecromancerSkeletonRespawn>();
            StartCoroutine(SpawnWithDelay());
        }

        private IEnumerator SpawnWithDelay()
        {
            var waitForSeconds = new WaitForSeconds(spawnDelaySeconds);
            while (true)
            {
                foreach (var necromancer in _necromancers)
                {
                    necromancer.Spawn();
                    yield return waitForSeconds;
                }
            }
        }
    }
}