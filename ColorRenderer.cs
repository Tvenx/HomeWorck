
using UnityEngine;

public class ColorRenderer : MonoBehaviour
{
    public static void ApplyColor(GameObject newCube)
    {
        newCube.GetComponent<Renderer>().material.color = Random.ColorHSV();
    }
}
