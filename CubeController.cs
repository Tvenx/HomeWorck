
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private CubeController _cubePrefab;

    [SerializeField] private float _explosionForce = 10f;
    [SerializeField] private float _spawnRadius = 2f;
    [SerializeField] private float _scaleFactor = 0.5f;

    [SerializeField] private int _minRange = 2;
    [SerializeField] private int _maxRange = 6;

    private void Start()
    {
        _cubePrefab = this;
    }

    private void OnMouseDown()
    {
        CubeSpawner.SpawnCubes(_minRange, _maxRange, _explosionForce, _spawnRadius, _scaleFactor, _cubePrefab, transform);
        Destroy(gameObject);
    }
}


