using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }

    void OnCollisionEnter(Collision collision)
    {



        if (collision.collider.tag == "box")
        {
            collision.gameObject.GetComponent<MeshRenderer>().material.color = Color.yellow;
            Debug.Log("collision detected" + collision.collider.tag);
        }


    }
}
