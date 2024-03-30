using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxLightsUp : MonoBehaviour
{
    MeshRenderer meshRenderer;
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            ChageColor();
        }
    }

    void ChageColor()
    {
        meshRenderer.material.color = new Color(1, 1, 0);
        Debug.Log("I key was pressed");
    }
}
