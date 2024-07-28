
using TMPro;
using UnityEngine;

public class CounterView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI counterText;

    private Counter counter;

    private void Start()
    {
        counter = GetComponent<Counter>(); 
    }

    private void Update()
    {
        counterText.text = counter.CounterValue.ToString("");
    }
}
