using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToScene : MonoBehaviour
{
    public string sceneName = "New scene name here";

    public bool isAutomatic;

    private bool manualEnter;

    void Update()
    {
        if (!isAutomatic && !manualEnter)
        {
            manualEnter = Input.GetButtonDown("Fire1");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            if (isAutomatic)
            {
                SceneManager.LoadScene(sceneName);
            }
        } 
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.name == "Player")
        {
            if(!isAutomatic && manualEnter)
            {
                SceneManager.LoadScene(sceneName);
            }
        }
    }
}
