using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class SliderHealthDisplayer : HealthDisplayer
{
    protected Slider _slider;

    protected virtual void Awake()
    {
        _slider = GetComponent<Slider>();
    }

    protected virtual void Start()
    {
        _slider.maxValue = _health.GetMaxHealth();
        _slider.minValue = 0;
    }

    protected virtual void Update()
    {
        ChangeValue();
    }

    protected virtual void ChangeValue()
    {
        _slider.value = _health.GetCurrentHealth();
    }
}
