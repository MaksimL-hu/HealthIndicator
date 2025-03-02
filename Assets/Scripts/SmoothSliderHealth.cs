using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SmoothSliderHealth : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private Slider _slider;
    [SerializeField] private float _timeSmooth;

    private Coroutine _coroutine;

    private void OnEnable()
    {
        _health.HealthChanged += ChangValue;
    }

    private void OnDisable()
    {
        _health.HealthChanged -= ChangValue;
    }

    private void ChangValue()
    {
        if (_coroutine != null)
            StopCoroutine(_coroutine);

        _coroutine = StartCoroutine(ChangingValue());
    }

    private IEnumerator ChangingValue()
    {
        float start = _slider.value;
        float end = _health.CurrentHealth / _health.MaxHealth;
        float time = 0f;

        while (time < _timeSmooth)
        {
            time += Time.deltaTime;

            _slider.value = Mathf.Lerp(start, end, time / _timeSmooth);
            yield return null;
        }
    }
}