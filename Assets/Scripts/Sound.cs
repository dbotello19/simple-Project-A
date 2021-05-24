using UnityEngine;

public class Sound : MonoBehaviour
{
    private AudioSource _audioSource;
    public static Sound instance;

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }

}
