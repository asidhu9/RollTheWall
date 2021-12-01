using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    float levelLoadDelay = 1f;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            Invoke("LoadFirstScene", levelLoadDelay);
        }
    }
    
    private void LoadFirstScene()
    {
        SceneManager.LoadScene(0);
    }
}
