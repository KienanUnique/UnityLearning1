using System.Collections;
using UnityEngine;

namespace Code_recommendations_HW_1
{
    [RequireComponent(typeof(AudioSource))]
    public class DoorAlarm : MonoBehaviour
    {
        [SerializeField] private float changeVolumeDelayInSeconds = 0.3f;
        private AudioSource _audioSource;
        private const float MinVolume = 0;
        private const float MaxVolume = 1;

        private void Start()
        {
            _audioSource = GetComponent<AudioSource>();
        }

        public void Alarm()
        {
            Debug.Log("Alarm!");
            _audioSource.Play();
            StartCoroutine(ChangeAlarmVolumePerFrame());
        }

        private IEnumerator ChangeAlarmVolumePerFrame()
        {
            var volumeA = MinVolume;
            var volumeB = MaxVolume;
            var currentInterpolation = 0.0f;
            var waitForNextStep = new WaitForSeconds(changeVolumeDelayInSeconds);
            while (true)
            {
                _audioSource.volume = Mathf.Lerp(volumeA, volumeB, currentInterpolation);

                currentInterpolation += 0.5f * Time.deltaTime;
                if (currentInterpolation > 1.0f)
                {
                    (volumeA, volumeB) = (volumeB, volumeA);
                    currentInterpolation = 0.0f;
                }

                yield return waitForNextStep;
            }
        }
    }
}