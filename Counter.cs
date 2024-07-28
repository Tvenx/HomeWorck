using System.Collections;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private float addValue = 1f;
    private float _counterValue = 0f;
    private float _interval = 0.5f;

    private Coroutine _coroutine;
    private bool _isTimerActive = true;

    public float CounterValue => _counterValue;

    private void Start()
    {
        _coroutine = StartCoroutine(IncrementCounter(_interval));
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (_isTimerActive)
                StopCoroutine(_coroutine);
            else
                _coroutine = StartCoroutine(IncrementCounter(_interval));

            _isTimerActive = !_isTimerActive;
        }
    }

    private IEnumerator IncrementCounter(float delay)
    {
        var wait = new WaitForSeconds(delay);
        while (true)
        {
            yield return wait;
            if (_isTimerActive)
                _counterValue += addValue;
        }
    }
}
