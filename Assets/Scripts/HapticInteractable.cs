using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class HapticInteractable : MonoBehaviour
{
    [Range(0, 1)]
    public float intensity;
    public float duration;
    public AudioClip feedbackSound;
    private AudioSource audioSource;
    private XRBaseController controller;

    void Start()
    {
        XRBaseInteractable interactable = GetComponent<XRBaseInteractable>();
        interactable.selectEntered.AddListener(TriggerHaptic);
        
        
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

   
    public void TriggerHaptic(BaseInteractionEventArgs eventArgs)
    {
        if(eventArgs.interactorObject is XRBaseControllerInteractor controllerInteractor)
        {
            controller = controllerInteractor.xrController;
        }

    }
    public void TriggerHaptic()
    {
        if (feedbackSound != null)
        {
            audioSource.PlayOneShot(feedbackSound);
        }
        if (intensity > 0)
        {
            controller.SendHapticImpulse(intensity,duration);
            
        }
    }
}
