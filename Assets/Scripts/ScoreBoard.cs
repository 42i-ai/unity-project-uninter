using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBoard : MonoBehaviour
{
    // Start is called before the first frame update
    private bool barrelCaptured = false;
    private int boxedTurnedYellow = 0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void setBarrelCaptured()
    {
        this.barrelCaptured = true;
        if (this.boxedTurnedYellow == 5)
        {
            Debug.Log("You win!");
        }
    }

    public bool getBarrelCaptured()
    {
        return this.barrelCaptured;
    }


    public void setBoxedTurnedYellow()
    {
        this.boxedTurnedYellow += 1;

    }
}
