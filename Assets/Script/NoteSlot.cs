using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NoteSlot : MonoBehaviour
{
    public SpriteRenderer Renderer;
    [SerializeField] private AudioSource noteSound;
    public void Placed()
    {
        noteSound.Play();
        Invoke("ChangeScene", 2.0f);
    }

    public void ChangeScene()
    {
        if (SceneManager.GetActiveScene().buildIndex + 1 < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
            
    }
}
