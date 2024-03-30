using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform objectToFollow;
    public Vector3 offset;
    void Start()
    {
        offset = objectToFollow.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = objectToFollow.position - offset;
    }
}
