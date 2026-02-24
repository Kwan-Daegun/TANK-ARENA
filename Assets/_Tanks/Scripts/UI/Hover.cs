using UnityEngine;

public class Hover : MonoBehaviour
{
    public float amplitude = 10f;   
    public float frequency = 1f;    

    RectTransform rt;
    Vector2 startPos;

    void Awake()
    {
        rt = GetComponent<RectTransform>();
        startPos = rt.anchoredPosition;
    }

    void Update()
    {
        float y = Mathf.Sin(Time.unscaledTime * frequency * Mathf.PI * 2f) * amplitude;
        rt.anchoredPosition = startPos + Vector2.up * y;
    }
}