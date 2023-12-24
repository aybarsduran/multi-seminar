using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public AudioSource menuMusic;
    public Toggle toggleAvatar1;
    public Toggle toggleAvatar2;
    public Toggle toggleAvatar3;
    public Toggle toggleAvatar4;
    public MenuSound sound;

    private void Start()
    {
        // menuMusic.Play();
        toggleAvatar1.onValueChanged.AddListener(OnToggleAvatar1);
        toggleAvatar2.onValueChanged.AddListener(OnToggleAvatar2);
        toggleAvatar3.onValueChanged.AddListener(OnToggleAvatar3);
        toggleAvatar4.onValueChanged.AddListener(OnToggleAvatar4);

    }
    private void OnToggleAvatar1(bool isOn)
    {
        if (isOn)
        {
            AvatarSelection.Instance.selectedAvatarIndex = 1;
            sound.PlayButtonClickSound();
        }

    }

    private void OnToggleAvatar2(bool isOn)
    {
        if (isOn)
        {
            AvatarSelection.Instance.selectedAvatarIndex = 2;
            sound.PlayButtonClickSound();

        }

    }
    private void OnToggleAvatar3(bool isOn)
    {
        if (isOn)
        {
            AvatarSelection.Instance.selectedAvatarIndex = 3;
            sound.PlayButtonClickSound();

        }

    }
    private void OnToggleAvatar4(bool isOn)
    {
        if (isOn)
        {
            AvatarSelection.Instance.selectedAvatarIndex = 4;
            sound.PlayButtonClickSound();

        }

    }



    public void QuitApplication()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

}
