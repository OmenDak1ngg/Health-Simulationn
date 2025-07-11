using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] public float Max { get; private set; }

    public float Current { get; private set; }

    private void Awake()
    {
        Current = Max;
    }

    public void TakeDamage(float amount)
    {
        if (amount < 0)
            return;

        if (Current < amount)
        
            Current = 0;
        else
            Current -= amount;
    }

    public void TakeHeal(float amount)
    {
        if (amount < 0)
            return;

        if (Current + amount > Max)
            Current = Max;
        else
            Current += amount;
    }
}
