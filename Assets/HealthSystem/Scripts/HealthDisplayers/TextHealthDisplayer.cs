using TMPro;
using UnityEngine;

public class TextHealthDisplayer : HealthDisplayer
{
    [SerializeField] private TextMeshProUGUI _textMeshPro;

    private void Update()
    {
        _textMeshPro.text = $"{_health.GetCurrentHealth()}/{_health.GetMaxHealth()}";
    }
}
