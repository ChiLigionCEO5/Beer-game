using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    private AudioSource audioSource;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    public GameObject gameOvertext;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Touch trigger.");
        if (collision.tag == "Player")
        {

            gameOvertext.SetActive(true);
            // cue sound effect here
            audioSource.Play();
            Debug.Log("The player has touched the obstacle.");

        }
    }
}
