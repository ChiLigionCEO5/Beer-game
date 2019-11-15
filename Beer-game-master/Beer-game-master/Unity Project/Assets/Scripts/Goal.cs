using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
///  Detects when the ball touches the goal, and then win the level. 
/// </summary>
public class Goal : MonoBehaviour
{
    private AudioSource audioSource;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    public GameObject winText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Touch trigger.");
        if (collision.tag == "Player" && !Gameover.IsGameOver)
        {

            winText.SetActive(true);
            // cue sound effect here
            audioSource.Play();
            Debug.Log("The player has entered the goal.");

        }
    }
}
