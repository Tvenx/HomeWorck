
using UnityEngine;

public class ClickOnCube : MonoBehaviour
{
    private AddGravity _addGravityClass;
    private AddColor _addColorClass;

    [SerializeField] private GameObject cubePrefab;
    private float minScale = 0.3f;
    private float maxScale = 0.7f;

    private int minRange = 2;
    private int maxRange = 6;

    private void Start()
    {
        _addGravityClass = GetComponent<AddGravity>();
        _addColorClass = GetComponent<AddColor>();
    }

    private void OnMouseDown()
    {
        gameObject.SetActive(false);

        SpawnCube();
    }

    private void SpawnCube()
    {
        int newCubeCount = Random.Range(minRange, maxRange);

        for (int i = 0; i < newCubeCount; i++)
        {
            Vector3 spawnPosition = transform.position + Random.insideUnitSphere * 2f;
            GameObject newCube = Instantiate(cubePrefab, spawnPosition, Quaternion.identity);
            newCube.transform.localScale = Vector3.one * Random.Range(minScale, maxScale);

            _addColorClass.RenderColor(newCube);
            _addGravityClass.Explosion(newCube);
        }
    }
}
