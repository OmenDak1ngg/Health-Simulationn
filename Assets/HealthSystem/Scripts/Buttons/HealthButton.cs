using UnityEngine;
using UnityEngine.UI;

[RequireComponent (typeof(Button))]
public abstract class HealthButton : MonoBehaviour
{
    [SerializeField] protected Health Health;

    private Button _button;

    private void OnEnable()
    {
        _button.onClick.AddListener(OnClicked);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(OnClicked);    
    }

    private void Awake()
    {
        _button = GetComponent<Button>();
    }

    protected abstract void OnClicked();
}
