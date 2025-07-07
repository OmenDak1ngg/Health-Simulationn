using UnityEngine;

public class SmoothSliderHealthDisplayer : SliderHealthDisplayer
{
    [SerializeField] private float _healthDelta = 100;
    
    private float _displayedHealth;

    protected override void Start()
    {
        base.Start();
        _displayedHealth = _health.GetCurrentHealth();
        _slider.value = _displayedHealth;
    }

    protected override void Update()
    {
        base.Update();
    }

    protected override void ChangeValue()
    {
        _displayedHealth = Mathf.MoveTowards(_displayedHealth, _health.GetCurrentHealth(), _healthDelta * Time.deltaTime);
        _slider.value = _displayedHealth;
    }
}
