using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableFloor : MonoBehaviour
{
    // Start is called before the first frame update
    private int health = 100;
    const int healthYellow = 80;
    const int healthRed = 25;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TakeDamage(int damage)
    {
        Debug.Log("health: " + health);
        health -= damage;

        switch (health)
        {
            case healthYellow:
                this.gameObject.GetComponent<MeshRenderer>().material.color = Color.yellow;
                break;
            case healthRed:
                this.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
                break;
            case 0:
                Destroy(gameObject);
                break;
        }



    }
}
