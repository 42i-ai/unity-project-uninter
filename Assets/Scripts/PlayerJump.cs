using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerJump : MonoBehaviour
{
    // Start is called before the first frame update
    public float jumpForce = 5;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

    }
    void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        Debug.Log("Jumping");
    }
}
