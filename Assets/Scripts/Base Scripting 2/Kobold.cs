using UnityEngine;
using UnityEngine.Events;

namespace Base_Scripting_2
{
    public class Kobold : MonoBehaviour
    {
        [SerializeField] private UnityEvent hit;


        public event UnityAction OnDamageTaken
        {
            add => hit.AddListener(value);
            remove => hit.RemoveListener(value);
        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.CompareTag("Killing"))
            {
                hit.Invoke();
            }
        }
    }
}