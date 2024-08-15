
using UnityEngine;

public class CubeSpawner
{
    public static void SpawnCubes(int minRange, int maxRange, float explosionForce,float spawnRadius, float scaleFactor, CubeController cubePrefab, Transform parentTransform)
    {
        int newCubeCount = Random.Range(minRange, maxRange);

        for (int i = 0; i < newCubeCount; i++)
        {
            Vector3 spawnPosition = parentTransform.position + Random.insideUnitSphere * spawnRadius;
            CubeInteractor newCube = Object.Instantiate(cubePrefab, spawnPosition, Quaternion.identity);
            newCube.transform.localScale = parentTransform.localScale * scaleFactor;

            ColorRenderer.ApplyColor(newCube.gameObject);
            ExplosionHandler.ApplyExplosionForce(newCube.gameObject, parentTransform.position, explosionForce);
        }
    }
}

