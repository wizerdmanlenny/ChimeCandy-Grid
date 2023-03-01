using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteSlot : MonoBehaviour
{
    public SpriteRenderer Renderer;
    [SerializeField] private AudioSource noteSound;
    public void Placed()
    {
        noteSound.Play();
    }
}
