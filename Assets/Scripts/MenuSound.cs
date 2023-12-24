using UnityEngine;
using UnityEngine.UI;

public class MenuSound : MonoBehaviour
{
    public AudioClip clickSound; 

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();

        audioSource.clip = clickSound;

    }

    public void PlayButtonClickSound()
    {
        audioSource.Play();
    }
}
