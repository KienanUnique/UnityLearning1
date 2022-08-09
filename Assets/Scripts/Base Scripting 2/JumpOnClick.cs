using UnityEngine;
using UnityEngine.EventSystems;

namespace Base_Scripting_2
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class JumpOnClick : MonoBehaviour, IPointerClickHandler
    {
        [SerializeField] private float jumpForce;
        private Rigidbody2D _rigidbody2D;

        private void Start()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            _rigidbody2D.AddForce(Vector2.up * jumpForce);
        }
    }
}