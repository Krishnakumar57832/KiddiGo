using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private AudioSource finishsound;
    private bool levelcompleted = false;
    void Start()
    {
        finishsound= GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player" && !levelcompleted)
        {
            finishsound.Play();
            levelcompleted = true;  
            Invoke("completelevel", 2f);
             
        }
    }
    private void completelevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
