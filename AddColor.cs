using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddColor : MonoBehaviour
{
    public void RenderColor(GameObject newCube)
    {
        newCube.GetComponent<Renderer>().material.color = Random.ColorHSV();
    }
}
