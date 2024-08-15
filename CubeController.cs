
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private CubeController _cubePrefab;

    [SerializeField] private float _explosionForce = 10f;
    [SerializeField] private int _minRange = 2;
    [SerializeField] private int _maxRange = 6;

    private void Start()
    {
        _cubePrefab = this;
    }

    private void OnMouseDown()
    {
        CubeSpawner.SpawnCubes(_minRange, _maxRange, _explosionForce, _cubePrefab, transform);
        Destroy(gameObject);
    }
}


