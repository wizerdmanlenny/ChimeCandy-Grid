using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    [SerializeField] private AudioSource noteSound;
    // Checks if the player is colliding with the note (valid play time for the note)
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        noteSound.Play();
    }
}
