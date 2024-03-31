using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerCollision : MonoBehaviour
{
    // Start is called before the first frame update
    public ScoreBoard scoreBoard;
    void Start()
    {
        scoreBoard = GameObject.FindAnyObjectByType<ScoreBoard>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.tag == "box")
        {
            if (collision.gameObject.GetComponent<MeshRenderer>().material.color != Color.yellow)
            {
                this.scoreBoard.setBoxedTurnedYellow();
            }
            collision.gameObject.GetComponent<MeshRenderer>().material.color = Color.yellow;
            Debug.Log("collision detected" + collision.collider.tag);
        }
        else if (collision.collider.tag == "collectible")
        {
            Destroy(collision.gameObject);
            this.scoreBoard.setBarrelCaptured();
        }


    }

    void OnCollisionStay(Collision collision)
    {
        if (collision.collider.GetComponent<BreakableFloor>() != null)
        {
            collision.gameObject.GetComponent<BreakableFloor>().TakeDamage(1, this.scoreBoard);
        }

    }


}
