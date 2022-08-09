using UnityEngine;

namespace Base_Scripting_2
{
    public class TargetFollower : MonoBehaviour
    {
        [SerializeField] private GameObject followTarget;
        [SerializeField] private float percentSpeedPerFrame = 0.006f;

        private const float MinPercentSpeedPerFrame = 0.001f;

        private void OnValidate()
        {
            if (percentSpeedPerFrame <= 0)
            {
                percentSpeedPerFrame = MinPercentSpeedPerFrame;
            }
        }

        private void Update()
        {
            transform.position =
                Vector3.Lerp(transform.position, followTarget.transform.position, percentSpeedPerFrame);
        }
    }
}