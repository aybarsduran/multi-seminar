using UnityEngine;
using UnityEngine.UI;

public class AvatarSelection : MonoBehaviour
{
    public static AvatarSelection Instance { get; private set; }

    public int selectedAvatarIndex = 1;

   
    public bool isMovementAvailable;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

   

}
