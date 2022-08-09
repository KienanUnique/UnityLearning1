using UnityEngine;
using UnityEngine.Events;

namespace Code_recommendations_HW_1
{
    [RequireComponent(typeof(BoxCollider2D))]
    public class Door : MonoBehaviour
    {
        [SerializeField] private UnityEvent somebodyNearDoor;

        public event UnityAction SomebodyNearDoor
        {
            add => somebodyNearDoor.AddListener(value);
            remove => somebodyNearDoor.RemoveListener(value);
        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            somebodyNearDoor.Invoke();
        }
    }
}