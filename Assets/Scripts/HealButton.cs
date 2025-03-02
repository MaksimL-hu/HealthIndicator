using UnityEngine;
using UnityEngine.UI;

public class HealButton : MonoBehaviour
{
    [SerializeField] private float _heal;
    [SerializeField] private Button _button;
    [SerializeField] private Health _health;

    private void OnEnable()
    {
        _button.onClick.AddListener(Heal);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(Heal);
    }

    private void Heal()
    {
        _health.Heal(_heal);
    }
}