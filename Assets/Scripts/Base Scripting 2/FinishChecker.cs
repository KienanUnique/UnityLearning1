using System.Linq;
using UnityEngine;
using UnityEngine.Events;

namespace Base_Scripting_2
{
    public class FinishChecker : MonoBehaviour
    {
        private CheckPoint[] _checkPoints;
        private bool _isAllReached;
        [SerializeField] private UnityEvent allCheckPointsReached;

        public event UnityAction AllCheckPointsReached
        {
            add => allCheckPointsReached.AddListener(value);
            remove => allCheckPointsReached.RemoveListener(value);
        }

        private void Awake()
        {
            _checkPoints = gameObject.GetComponentsInChildren<CheckPoint>();
        }

        private void OnEnable()
        {
            foreach (var checkPoint in _checkPoints)
            {
                checkPoint.Reached += OnReached;
            }
        }

        private void OnDisable()
        {
            foreach (var checkPoint in _checkPoints)
            {
                checkPoint.Reached -= OnReached;
            }
        }

        private void OnReached()
        {
            if (_isAllReached || _checkPoints.Any(checkPoint => !checkPoint.IsReached))
            {
                return;
            }

            _isAllReached = true;
            allCheckPointsReached.Invoke();
        }
    }
}