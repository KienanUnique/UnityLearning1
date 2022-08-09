using UnityEngine;
using UnityEngine.Events;

namespace Base_Scripting_2
{
    public class CheckPoint : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer spriteRenderer;
        [SerializeField] private Color checkedColor;
        [SerializeField] private UnityEvent reached;

        public event UnityAction Reached
        {
            add => reached.AddListener(value);
            remove => reached.RemoveListener(value);
        }

        public bool IsReached { get; private set; }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (!IsReached)
            {
                IsReached = true;
                spriteRenderer.color = checkedColor;
                reached.Invoke();
            }
        }
    }
}