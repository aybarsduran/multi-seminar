using UnityEngine;
using UnityEngine.UI;

public class SoundButtonController : MonoBehaviour
{
    public Sprite soundOnSprite; 
    public Sprite soundOffSprite; 
    public AudioSource audioSource; 

    private bool isSoundOn = true; 

    private Image buttonImage; 

    private void Start()
    {
        buttonImage = GetComponent<Image>();
        UpdateButtonVisual();
    }

    public void ToggleSound()
    {
        isSoundOn = !isSoundOn;
        UpdateButtonVisual();

        if (isSoundOn)
        {
          
            audioSource.Play();
        }
        else
        {
            
            audioSource.Stop(); 
        }
    }

    private void UpdateButtonVisual()
    {
        if (isSoundOn)
        {
           
            buttonImage.sprite = soundOnSprite;
        }
        else
        {
           
            buttonImage.sprite = soundOffSprite;
        }
    }
}
