using UnityEngine;
using UnityEngine.UI;

public class SliderHealth : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private Slider _slider;

    private void Start()
    {
        _slider.maxValue = _health.MaxHealth;
        _slider.minValue = 0;
    }

    private void OnEnable()
    {
        _health.HealthChanged += ChangeValue;
    }

    private void OnDisable()
    {
        _health.HealthChanged -= ChangeValue;   
    }

    private void ChangeValue()
    {
        _slider.value = _health.CurrentHealth;
    }
}