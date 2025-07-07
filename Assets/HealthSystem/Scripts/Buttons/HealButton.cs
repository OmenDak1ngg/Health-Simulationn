using UnityEngine;

public class HealButton : HealthButton
{
    [SerializeField] private float _heal;

    protected override void OnClicked()
    {
        _health.TakeHeal(_heal);
    }
}
