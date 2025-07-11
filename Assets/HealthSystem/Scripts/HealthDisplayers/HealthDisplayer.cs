using System.Collections;
using UnityEngine;

abstract public class HealthDisplayer : MonoBehaviour
{
    [SerializeField] protected Health Health;

    protected virtual void Start()
    {
        StartCoroutine(UpdateHealthDisplay());
    }

    protected abstract IEnumerator UpdateHealthDisplay();
}
