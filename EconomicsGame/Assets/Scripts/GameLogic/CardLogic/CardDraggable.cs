using UnityEngine;
using UnityEngine.EventSystems;

namespace GameLogic.CardLogic
{
    public class CardDraggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
    {
        private CanvasGroup canvasGroup;
        private Vector3 startPos;
        private Transform originalParent;

        void Awake()
        {
            canvasGroup = GetComponent<CanvasGroup>();
        }

        public void OnBeginDrag(PointerEventData eventData)
        {
            startPos = transform.position;
            originalParent = transform.parent;
            transform.SetParent(transform.root); // na wierzch
            canvasGroup.blocksRaycasts = false;
        }

        public void OnDrag(PointerEventData eventData)
        {
            transform.position = Input.mousePosition;
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            transform.SetParent(originalParent);
            transform.position = startPos;
            canvasGroup.blocksRaycasts = true;
        }
    }
}