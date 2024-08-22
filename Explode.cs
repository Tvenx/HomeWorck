
using UnityEngine;

public class Explode : MonoBehaviour
{
    public static void ApplyExplode(float explosionRadius, float explosionForce, float upwardsModifier, Transform transform)
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius);
        foreach (Collider nearbyObject in colliders)
        {
            Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                Vector3 explosionDirection = nearbyObject.transform.position - transform.position;
                float distance = explosionDirection.magnitude;
                if (distance > 0.1f)
                {
                    float force = explosionForce / distance;
                    rb.AddExplosionForce(force, transform.position, explosionRadius, upwardsModifier, ForceMode.Impulse);
                }
            }
        }
    }
}


