using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Button))]
public class AnimatedButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerExitHandler
{
    [Header("Text Colors")]
    private Color _defaultTextColor;
    [SerializeField] private Color _pressedTextColor = new Color(0.8f, 0.6f, 0.4f, 1f);

    private TextMeshProUGUI buttonText;

    private void Awake()
    {
        buttonText = GetComponentInChildren<TextMeshProUGUI>();
        _defaultTextColor = buttonText.color;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        SetColor(_pressedTextColor);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        SetColor(_defaultTextColor);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        SetColor(_defaultTextColor);
    }

    private void SetColor(Color color)
    {
        if (buttonText != null)
            buttonText.color = color;
    }
}