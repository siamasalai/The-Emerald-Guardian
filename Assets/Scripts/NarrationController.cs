using UnityEngine;

public class NarrationController : MonoBehaviour
{
    private AudioSource audioSource;

    void Awake()
    {
        // Get the AudioSource component attached to this GameObject.
        audioSource = GetComponent<AudioSource>();
    }

    // This public function will be called by the UI button.
    public void ToggleNarration()
    {
        if (audioSource.isPlaying)
        {
            // If the audio is currently playing, stop it.
            audioSource.Stop();
        }
        else
        {
            // If the audio is not playing, start it from the beginning.
            audioSource.Play();
        }
    }
}