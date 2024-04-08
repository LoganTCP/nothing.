using UnityEngine;
using UnityEngine.UI;

public class AmbientSoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource ambientAudioSource;
    [SerializeField] private Slider volumeSlider;

    void Start()
    {
        if (!PlayerPrefs.HasKey("ambVolume"))
        {
            PlayerPrefs.SetFloat("ambVolume", 1);
            Load();
        }
        else
        {
            Load();
        }

        // Add listener to the volume slider's On Value Changed event
        volumeSlider.onValueChanged.AddListener(delegate { ChangeVolume(); });
    }

    // Called when the volume slider changes
    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        ambientAudioSource.volume = volumeSlider.value;
        Save();
    }

    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("ambVolume");
        // Apply the volume immediately when loading
        AudioListener.volume = volumeSlider.value;
        ambientAudioSource.volume = volumeSlider.value;
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("ambVolume", volumeSlider.value);
    }
}
