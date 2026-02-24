using UnityEngine;
using UnityEngine.EventSystems;

public class Hover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public float offset = 10f;
    public float speed = 10f;

    RectTransform rt;
    Vector2 startPos;
    Vector2 targetPos;

    void Awake()
    {
        rt = GetComponent<RectTransform>();
        startPos = rt.anchoredPosition;
        targetPos = startPos;
    }

    void Update()
    {
        rt.anchoredPosition =
            Vector2.Lerp(rt.anchoredPosition, targetPos, Time.deltaTime * speed);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        targetPos = startPos + Vector2.up * offset;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        targetPos = startPos;
    }
}