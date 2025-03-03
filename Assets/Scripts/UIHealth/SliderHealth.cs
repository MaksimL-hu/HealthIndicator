using UnityEngine;
using UnityEngine.UI;

public class SliderHealth : UIHealth
{
    [SerializeField] protected Slider _slider;

    protected override void ChangeValue()
    {
        _slider.value = _health.CurrentHealth / _health.MaxHealth;
    }
}