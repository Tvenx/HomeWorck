
using UnityEngine;

public class ExplosionHandler
{
    public static void ApplyExplosionForce(GameObject cube, Vector3 origin, float explosionForce)
    {
        Rigidbody cubeRb = cube.GetComponent<Rigidbody>();
        if (cubeRb != null)
        {
            Vector3 explosionDirection = cube.transform.position - origin;
            cubeRb.AddForce(explosionDirection.normalized * explosionForce, ForceMode.Impulse);
        }
    }
}
