using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Space) && SceneManager.GetActiveScene().name != "PhaseOne")
        {
            SceneManager.LoadScene("PhaseOne");
        }
        if (Input.GetKeyDown(KeyCode.N) && SceneManager.GetActiveScene().name != "PhaseOne")
        {
            SceneManager.LoadScene("PhaseOne");
        }
    }
}
