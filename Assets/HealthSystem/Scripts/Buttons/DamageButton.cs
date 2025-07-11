using UnityEngine;

public class DamageButton : HealthButton
{
    [SerializeField] private float _damage;

    protected override void OnClicked()
    {
        Health.TakeDamage(_damage);
    }
}
