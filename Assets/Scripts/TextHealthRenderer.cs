using TMPro;
using UnityEngine;

public class TextHealthRenderer : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private string _gapSymbol;

    private void OnEnable()
    {
        _health.HealthChanged += RenderText;
    }

    private void OnDisable()
    {
        _health.HealthChanged -= RenderText;
    }

    private void RenderText()
    {
        _text.text = _health.CurrentHealth + _gapSymbol + _health.MaxHealth;
    }
}