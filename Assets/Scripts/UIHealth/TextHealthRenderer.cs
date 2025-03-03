using TMPro;
using UnityEngine;

public class TextHealthRenderer : UIHealth
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private string _gapSymbol;

    protected override void ChangeValue()
    {
        _text.text = _health.CurrentHealth + _gapSymbol + _health.MaxHealth;
    }
}