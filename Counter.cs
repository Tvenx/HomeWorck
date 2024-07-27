using System.Collections;
using UnityEngine;

public class Counter : MonoBehaviour
{
    private float _counterValue = 0f;
    private float _interval = 0.5f;

    public float addValue = 1f;

    public float CounterValue => _counterValue;

    private bool isCounting = false;

    public void OnMouseDown()
    {
        isCounting = !isCounting;

        if (isCounting)
            StartCoroutine(IncrementCounter());

        if (!isCounting)
             StopAllCoroutines();
    }

    private IEnumerator IncrementCounter()
    {
        while (true)
        {
            yield return new WaitForSeconds(_interval);
            _counterValue += addValue;
        }
    }
}
