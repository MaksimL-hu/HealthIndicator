using UnityEngine;
using UnityEngine.UI;

public class DamageButton : MonoBehaviour
{
    [SerializeField] private float _damage;
    [SerializeField] private Button _button;
    [SerializeField] private Health _health;

    private void OnEnable()
    {
        _button.onClick.AddListener(Damage);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(Damage);
    }

    private void Damage()
    {
        _health.Damage(_damage);
    }
}