using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ScoreBoard : MonoBehaviour
{
    // Start is called before the first frame update
    private bool barrelCaptured = false;
    private int boxedTurnedYellow = 0;
    private float ykillPlayer = -20;
    public Transform playerRefence;
    void Start()
    {
        this.playerRefence = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerRefence.position.y < ykillPlayer)
        {
            Debug.Log("You lose!");
            SceneManager.LoadScene("GameOver");
        }
    }

    public void setBarrelCaptured()
    {
        this.barrelCaptured = true;
        if (this.boxedTurnedYellow == 5)
        {
            Debug.Log("You win!");
            SceneManager.LoadScene("Win");
        }
    }

    public bool getBarrelCaptured()
    {
        return this.barrelCaptured;
    }


    public void setBoxedTurnedYellow()
    {
        int totalBox = 5 - this.boxedTurnedYellow;
        this.boxedTurnedYellow += 1;
        Debug.Log("Nice another box, let's go! you need :" + totalBox + " more");
        if (this.barrelCaptured == true)
        {
            Debug.Log("You win!");
            SceneManager.LoadScene("Win");
        }

    }
}
