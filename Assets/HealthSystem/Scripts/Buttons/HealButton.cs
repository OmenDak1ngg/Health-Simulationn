using UnityEngine;

public class HealButton : HealthButton
{
    [SerializeField] private float _heal;

    protected override void OnClicked()
    {
        Health.TakeHeal(_heal);
    }
}
