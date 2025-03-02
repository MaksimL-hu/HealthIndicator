using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    public event Action HealthChanged;

    [SerializeField] private float _maxHealth;

    private float _currentHealth;

    public float MaxHealth => _maxHealth;
    public float CurrentHealth => _currentHealth;

    private void Start()
    {
        _currentHealth = _maxHealth;
        HealthChanged?.Invoke();
    }

    public void Heal(float health)
    {
        float currentHealth = _currentHealth + health;

        if (currentHealth > _maxHealth)
            _currentHealth = _maxHealth;
        else
            _currentHealth = currentHealth;

        HealthChanged?.Invoke();
    }

    public void Damage(float health)
    {
        float currentHealth = _currentHealth - health;

        if (currentHealth < 0)
            _currentHealth = 0;
        else
            _currentHealth = currentHealth;

        HealthChanged?.Invoke();
    }
}