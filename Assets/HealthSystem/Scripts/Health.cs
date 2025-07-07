using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float _maxHealth;

    private float _currentHealth;

    private void Awake()
    {
        _currentHealth = _maxHealth;
    }

    public void TakeDamage(float damage)
    {
        if(_currentHealth < damage)
        
            _currentHealth = 0;
        else
            _currentHealth -= damage;
    }

    public void TakeHeal(float heal)
    {
        if (_currentHealth + heal > _maxHealth)
            _currentHealth = _maxHealth;
        else
            _currentHealth += heal;
    }

    public float GetCurrentHealth()
    {
        return _currentHealth;
    }

    public float GetMaxHealth()
    {
        return _maxHealth;
    }
}
