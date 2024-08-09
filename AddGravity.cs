using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddGravity : MonoBehaviour
{
    private float explosionForce = 10f;
    public void Explosion(GameObject newCube)
    {
        Rigidbody newCubeRb = newCube.GetComponent<Rigidbody>();
        newCubeRb.useGravity = true;

        Vector3 explosionDirection = newCube.transform.position - transform.position;
        newCubeRb.AddForce(explosionDirection.normalized * explosionForce, ForceMode.Impulse);
    }
}
