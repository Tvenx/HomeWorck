using System.Collections;
using TMPro;
using UnityEngine;

public class Counter : MonoBehaviour
{
   [SerializeField] private float _interval = 0.5f;

   [SerializeField] private int _addNumber = 1;
    private int _count = 0;

    private bool isCounting = false;

    public TextMeshProUGUI _counterTextMeshPro;

    private IEnumerator Start()
    {
        while (true)
        {
            if (isCounting)
            {
                _count += _addNumber;
                _counterTextMeshPro.text = _count.ToString("");
                Debug.Log("Count: " + _count);
            }

            yield return new WaitForSeconds(_interval);
        }
    }

    public void OnMouseDown()
    {
        isCounting = !isCounting;
    }

   
}
