using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelFinish : MonoBehaviour
{
    float levelLoadDelay = 1f;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
            Invoke("LoadFirstScene", levelLoadDelay);
        }
    }

    private void LoadFirstScene()
    {
        SceneManager.LoadScene(0);
    }
}
